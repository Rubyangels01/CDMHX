using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class CHITIETCV : Form
    {
        DataConnection dc;
        SqlConnection connection;
        CHITIETCVDAO ctcvdao = new CHITIETCVDAO();

        public CHITIETCV()
        {
            dc = new DataConnection();
            connection = dc.getConnec();
            InitializeComponent();
        }
        public void LayMaCD()
        {         
            using (SqlCommand command = new SqlCommand("SELECT MaCD FROM CDMHX WHERE MaCD >= YEAR(GETDATE())", connection))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maNhom = reader["MaCD"].ToString();
                        cbNamCD.Items.Add(maNhom);
                        cbNamCD.SelectedIndex = 0;
                    }
                    reader.Close();
                }
            }
        }

        public void LayCongViec()
        {
            using (SqlCommand command = new SqlCommand("SELECT TenCV FROM CongViec", connection))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tencv = reader["TenCV"].ToString();
                        cbCV.Items.Add(tencv);
                        cbCV.SelectedIndex = 0;
                    }
                    reader.Close();
                }
            }
        }

        public void LayDB(string tenxa)
        {
            using (SqlCommand command = new SqlCommand(string.Format("SELECT TenDB FROM DIABAN WHERE MADB = (SELECT MADB FROM XA WHERE TENXA = N'{0}')",tenxa), connection))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string tendb = reader["TenDB"].ToString();
                        cbDiaBan.Items.Add(tendb);
                        cbDiaBan.SelectedIndex = 0;
                    }
                    reader.Close();
                }
            }
            

        }


        public void DSNhom()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            
            listboxNhom.Items.Clear();
            List<string> dsNhom = ctcvdao.LayNhom(cbXa.Text,dateNgay.Value,cbBuoi.Text, namcd);

            foreach (string nhom in dsNhom)
            {
                
                listboxNhom.Items.Add(nhom);
            }
        }
        public void DSNhomDaPC()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);

            listboxNhom2.Items.Clear();
            List<string> dsNhom = ctcvdao.LayNhomDaPC(cbXa.Text, dateNgay.Value, cbBuoi.Text, namcd);

            foreach (string nhom in dsNhom)
            {

                listboxNhom2.Items.Add(nhom);
            }
        }
        KIEMTRAPC_GV parentForm = Application.OpenForms.OfType<KIEMTRAPC_GV>().FirstOrDefault();
        private void CHITIETCV_Load(object sender, EventArgs e)
        {
            int namcd;
            
            
           
            //cbXa.SelectedIndex = 0;
            LayMaCD();
           
            
            cbXa.Items.AddRange(ctcvdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), parentForm.magv).ToArray());
            cbXa.SelectedIndex = 0;
            cbAp.Items.AddRange(ctcvdao.LayAp(cbXa.Text).ToArray());
            LayCongViec();
            cbBuoi.Items.Add("Buổi Sáng");
            cbBuoi.Items.Add("Buổi Chiều");
            cbBuoi.Items.Add("Buổi Tối");
            cbBuoi.SelectedIndex = 0;
            LayDB(cbXa.Text);
           
            
            //cbXa.SelectedIndex = 0;

        }
        
        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
            /*
            cbXa.Items.Clear();

            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbDiaBan.SelectedItem != null)
            {
               

            }*/
        }


        private void cbXa_TextChanged(object sender, EventArgs e)
        {
            cbAp.Items.Clear();

            // Kiểm tra xem đã chọn một danh mục trong combo box "cbDiaBan" hay chưa
            if (cbDiaBan.SelectedItem != null)
            {
                cbAp.Items.AddRange(ctcvdao.LayAp(cbXa.Text).ToArray());
                cbAp.SelectedIndex = 0;

            }
            
        }

        private void cbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                // Xóa các mục hiện có trong combo box "cbXa"
                
            

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DSNhom();
            DSNhomDaPC();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(listboxNhom.SelectedItem != null)
            {
                List<string> selectedItems = new List<string>();
                // Lặp qua các mục đã chọn trong listboxNhom
                foreach (object selectedItem in listboxNhom.SelectedItems)
                {
                    // Lấy nội dung của mục đã chọn
                    string item = selectedItem.ToString();
                    selectedItems.Add(item);

                    // Thêm nội dung vào ListBox chi tiết công việc
                    
                    ctcvdao.PhanCongCV(cbAp.Text, cbCV.Text, dateNgay.Value, cbBuoi.Text, item);
                    DSNhom();
                    DSNhomDaPC();
                }
                
                // Xóa các mục đã chọn khỏi listboxNhom
                foreach (string item in selectedItems)
                {
                    
                    listboxNhom.Items.Remove(item);
                }
                
                // Gọi phương thức PhanCongCV để thêm dữ liệu vào CSDL
                
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xoá sinh viên ra khỏi danh sách?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (listboxNhom2.SelectedItem != null)
                {
                    List<string> selectedItems = new List<string>();
                    foreach (object selectedItem in listboxNhom2.SelectedItems)
                    {
                        string item = selectedItem.ToString();
                        selectedItems.Add(item);
                        ctcvdao.XOACV(cbAp.Text, cbCV.Text, dateNgay.Value, cbBuoi.Text, item);

                    }


                    foreach (string item in selectedItems)
                    {
                        listboxNhom.Items.Add(item);
                        listboxNhom2.Items.Remove(item);


                    }


                }
            }    
                
        }
    }
    
}
