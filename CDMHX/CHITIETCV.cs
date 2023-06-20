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
        DataConnection dc ;
        SqlConnection connection;
        private TAOCHIENDICH parentForm = new TAOCHIENDICH();
        public CHITIETCV()
        {
            dc = new DataConnection();
            connection = dc.getConnec(); 
            
            InitializeComponent();
            
        }
        public CHITIETCV(TAOCHIENDICH form)
        {
            dc = new DataConnection();
            connection = dc.getConnec();

            InitializeComponent();
            parentForm = form;
        }
        public void LayTenCV()
        {
            
            {
               

                using (SqlCommand command = new SqlCommand("SELECT TenCV from CongViec", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenCongViec = reader["TenCV"].ToString();
                            listboxCongViec.Items.Add(tenCongViec);
                        }
                    }
                }
            }

        }
        public void LayTenNhom()
        {                     
                using (SqlCommand command = new SqlCommand("SELECT TenNhom from NhomSV", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenNhom = reader["TenNhom"].ToString();
                            listboxNhom.Items.Add(tenNhom);
                        }
                    }
                }          
        }
        public void LayDiaBan()
        {
            using (SqlConnection connection = dc.getConnec())
            {
                using (SqlCommand command = new SqlCommand("SELECT Ap.TenAp, Xa.TenXa, DiaBan.TenDB from Ap,Xa,DiaBan where Ap.MaXa = Xa.MaXa and Xa.MaDB = DiaBan.MaDB", connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tenAp = reader["TenAp"].ToString();
                            string tenXa = reader["TenXa"].ToString();
                            string tenDiaBan = reader["TenDB"].ToString();

                            string itemText = $"{tenAp}, {tenXa}, {tenDiaBan}"; // Ghép các thuộc tính thành một chuỗi

                            listboxDiaBan.Items.Add(itemText);
                        }
                    }
                }
            }
        }


        private void listboxCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void CHITIETCV_Load(object sender, EventArgs e)
        {
            cbBuoi.Items.Add("Buổi Sáng");
            cbBuoi.Items.Add("Buổi Chiều");
            cbBuoi.Items.Add("Buổi Tối");
            cbBuoi.SelectedIndex = 0;
            LayTenCV();
            LayTenNhom();
            LayDiaBan();

            //listboxCongViec.Items.Add("Xoài");
        }
        public List<string> CTCV = new List<string>();
        private void btnChuyenmot_Click(object sender, EventArgs e)
        {
            List<string> listnhom = new List<string>();
            List<string> listDB = new List<string>();
            
            string cv;

            // Kiểm tra danh mục Công việc đã được chọn
            if (listboxCongViec.SelectedIndices.Count > 0)
            {
                cv = listboxCongViec.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục trong Công việc.");
                return;
            }

            // Kiểm tra danh mục đã được chọn trong listboxNhom
            if (listboxNhom.SelectedIndices.Count > 0)
            {
                foreach (object selectedItem in listboxNhom.SelectedItems)
                {
                    string item = selectedItem.ToString();
                    listnhom.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục trong Nhóm.");
                return;
            }

            // Kiểm tra danh mục đã được chọn trong listboxDiaBan
            if (listboxDiaBan.SelectedIndices.Count > 0)
            {
                foreach (object selectedItem in listboxDiaBan.SelectedItems)
                {
                    string item = selectedItem.ToString();
                    listDB.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn danh mục trong Địa Bàn.");
                return;
            }

            string chiTietCV = $"{cv} - {string.Join(", ", listnhom)} - {string.Join(", ", listDB)} - {cbBuoi.SelectedItem} - {dateNgayChon.Text}";
            listboxCTCV.Items.Add(chiTietCV);
            CTCV.Add(chiTietCV);
            // Xoá các mục đã chọn trong ListBox gốc
            listboxCongViec.ClearSelected();
            listboxNhom.ClearSelected();
            listboxDiaBan.ClearSelected();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listboxCTCV.SelectedIndices.Count > 0)
            {
                // Xoá từng mục đã chọn trong listboxCTCV
                for (int i = listboxCTCV.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    int selectedIndex = listboxCTCV.SelectedIndices[i];
                    listboxCTCV.Items.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn mục để xoá.");
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            parentForm.showCV();
            this.Close();
        }

    }
}
