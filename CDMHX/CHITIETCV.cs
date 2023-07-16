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
       
        public List<tbCongViec> LayCV(string macd)
        {
            List<tbCongViec> listCV = new List<tbCongViec>();
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT CT_CD.MaCV,CONGVIEC.TenCV FROM CT_CD,CONGVIEC WHERE CONGVIEC.MACV = CT_CD.MACV AND MACD = {0}", macd));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbCongViec cv = new tbCongViec();
                string macv = reader["MaCV"].ToString();
                string tencv = reader["TenCV"].ToString();
                cv.MaCV = Program.ConvertStringToInt(macv);
                cv.TenCV = tencv;
                listCV.Add(cv);

            }
            reader.Close();
            Program.dc.getConnec().Close();
            return listCV;
        }
        

        


        public void DSNhom()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            
            listboxNhom.Items.Clear();
            List<string> dsNhom = ctcvdao.LayNhom(cbXa.SelectedValue.ToString(),dateNgay.Value,cbBuoi.Text, namcd);

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
            List<string> dsNhom = ctcvdao.LayNhomDaPC(cbXa.SelectedValue.ToString(), dateNgay.Value, cbBuoi.Text, namcd);

            foreach (string nhom in dsNhom)
            {

                listboxNhom2.Items.Add(nhom);
            }
        }
        int maGV;
        private void CHITIETCV_Load(object sender, EventArgs e)
        {
            KIEMTRAPC_GV parentForm = Application.OpenForms.OfType<KIEMTRAPC_GV>().FirstOrDefault();
            maGV = parentForm.magv;
            cbNamCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbNamCD.SelectedIndex = 0;
            cbXa.DataSource = ctcvdao.LayXa(Program.ConvertStringToInt(cbNamCD.Text), maGV);
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
            cbDiaBan.DataSource = ctcvdao.LayDB(cbXa.SelectedValue.ToString());
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            
            cbAp.DataSource = ctcvdao.LayAp(cbXa.SelectedValue.ToString());
            cbAp.DisplayMember = "TenAp";
            cbAp.ValueMember = "MaAp";
            
            cbCV.DataSource = LayCV(cbNamCD.Text);
            cbCV.DisplayMember = "TenCV";
            cbCV.ValueMember = "MaCV";
            cbBuoi.Items.Add("Buổi Sáng");
            cbBuoi.Items.Add("Buổi Chiều");
            cbBuoi.Items.Add("Buổi Tối");
            cbBuoi.SelectedIndex = 0;
          

        }
        
        private void cbDiaBan_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void cbXa_TextChanged(object sender, EventArgs e)
        {

           /*
            if (cbXa.SelectedItem != null)
            {
                cbAp.DataSource = ctcvdao.LayAp(cbXa.SelectedValue.ToString());
                cbAp.DisplayMember = "TenAp";
                cbAp.ValueMember = "MaAp";

                cbDiaBan.DataSource = ctcvdao.LayDB(cbXa.SelectedValue.ToString());
                cbDiaBan.DisplayMember = "TenDB";
                cbDiaBan.ValueMember = "MaDB";

            }*/
            
        }

        private void cbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            DSNhom();
            DSNhomDaPC();
        }
        public bool checkData() 
        {
            THEMCV_CD tcvcd = new THEMCV_CD();
            if (dateNgay.Value.Date < tcvcd.getDateBD(cbCV.SelectedValue.ToString()))
            {
                MessageBox.Show("Ngày thực hiện công việc " + cbCV.Text + " phải lớn hơn ngày " + tcvcd.getDateBD(cbCV.SelectedValue.ToString()) + " và nhỏ hơn ngày " + tcvcd.getDateKT(cbCV.SelectedValue.ToString()), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgay.Focus();
                return false;
            }
            if (dateNgay.Value.Date > tcvcd.getDateKT(cbCV.SelectedValue.ToString()))
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Ngày thực hiện công việc " + cbCV.Text + " phải lớn hơn ngày " + tcvcd.getDateBD(cbCV.SelectedValue.ToString()) + " và nhỏ hơn ngày " + tcvcd.getDateKT(cbCV.SelectedValue.ToString()), "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateNgay.Focus();
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (listboxNhom.SelectedItem != null)
            {
                if(checkData() == true)
                {
                    List<string> selectedItems = new List<string>();

                    // Lặp qua các mục đã chọn trong listboxNhom
                    foreach (string selectedItem in listboxNhom.SelectedItems)
                    {
                        selectedItems.Add(selectedItem);
                    }

                    // Thêm các mục đã chọn vào CSDL và làm các thay đổi khác
                    foreach (string selectedItem in selectedItems)
                    {
                        ctcvdao.PhanCongCV(cbAp.SelectedValue.ToString(), cbCV.SelectedValue.ToString(), dateNgay.Value, cbBuoi.Text, selectedItem);

                    }
                    DSNhom();
                    DSNhomDaPC();
                }    
                

            }
            else
            {
                MessageBox.Show("Bạn chưa chọn nhóm để thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {                   
                if (listboxNhom2.SelectedItem != null)
                {
                    if (MessageBox.Show("Bạn có muốn xoá sinh viên ra khỏi danh sách?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        List<string> selectedItems = new List<string>();
                        foreach (string selectedItem in listboxNhom2.SelectedItems)
                        {
                            selectedItems.Add(selectedItem);
                        }
                        foreach (string selectedItem in selectedItems)
                        {


                            ctcvdao.XOACV(cbAp.SelectedValue.ToString(),cbCV.SelectedValue.ToString(), dateNgay.Value, cbBuoi.Text, selectedItem);

                        }
                        DSNhom();
                        DSNhomDaPC();
                    }
                } 
                else
            {
                MessageBox.Show("Bạn chưa chọn nhóm để xoá!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }                                                                     
        }

        private void cbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbXa.SelectedItem != null)
            { 
                cbAp.DataSource = ctcvdao.LayAp(cbXa.SelectedValue.ToString());
                cbAp.DisplayMember = "TenAp";
                cbAp.ValueMember = "MaAp";
                
                cbDiaBan.DataSource = ctcvdao.LayDB(cbXa.SelectedValue.ToString());
                cbDiaBan.DisplayMember = "TenDB";
                cbDiaBan.ValueMember = "MaDB";

            }
        }

        private void CHITIETCV_FormClosing(object sender, FormClosingEventArgs e)
        {
            KIEMTRAPC_GV parentForm = Application.OpenForms.OfType<KIEMTRAPC_GV>().FirstOrDefault();
            // Hỏi người dùng xem có muốn thoát hay không
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi form này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng chọn "No", hủy sự kiện đóng form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
    
}
