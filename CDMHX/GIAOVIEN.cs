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
    public partial class GIAOVIEN : Form
    {
        int index = 0;
        string flag;
        GIAOVIENDAO gvdao = new GIAOVIENDAO();
        public GIAOVIEN()
        {
            InitializeComponent();
        }
        public void KhoaControl()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtMaGV.ReadOnly = true;
            txtTenGV.ReadOnly = true;
            cbTenKhoa.Enabled = false;

            btnThem.Focus();
        }


        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;


            txtMaGV.ReadOnly = true;
            txtTenGV.ReadOnly = false;
            cbTenKhoa.Enabled = true;
            txtTenGV.Focus();

        }
       
        public void ShowAllGV()
        {

            DataTable listCV = gvdao.GetAllGV();

            listGiaoVien.DataSource = listCV;

        }
        private void GIAOVIEN_Load(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllGV();
            cbTenKhoa.Items.Add("CÔNG NGHỆ THÔNG TIN");
            cbTenKhoa.Items.Add("KINH TẾ");
            cbTenKhoa.Items.Add("VIỄN THÔNG");
            cbTimKiemKhoa.Items.Add("CÔNG NGHỆ THÔNG TIN");
            cbTimKiemKhoa.Items.Add("KINH TẾ");
            cbTimKiemKhoa.Items.Add("VIỄN THÔNG");
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            
            flag = "add";
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
           
            flag = "edit";

            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllGV();
                KhoaControl();
            }
            else
            {
                string selectedKhoa = cbTenKhoa.Text; // Lưu giá trị hiện tại của ComboBox

                // Thực hiện các bước khác

                cbTenKhoa.Text = selectedKhoa; // Gán lại giá trị cho ComboBox
                
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllGV();
            

        }
        private void cbTenKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTenGV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên công việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenGV.Focus();
                return false;
            }
            


            return true;
        }
        int ID = 0;
        private void listGiaoVien_SelectionChanged(object sender, EventArgs e)
        {
            index = listGiaoVien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)listGiaoVien.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                int.TryParse(listGiaoVien.Rows[index].Cells[0].Value.ToString(), out ID);
                txtMaGV.Text = ID.ToString();
                txtTenGV.Text = listGiaoVien.Rows[index].Cells[1].Value.ToString();
                
                cbTenKhoa.Text = listGiaoVien.Rows[index].Cells[2].Value.ToString(); // Gán dữ liệu vào ComboBox
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    tbGiaoVien gv = new tbGiaoVien();
                    gv.TenGV = txtTenGV.Text;
                    gv.Khoa.TenKhoa = cbTenKhoa.Text;
                    
                    if (gvdao.ThemGV(gv))
                    {
                        ShowAllGV();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (flag == "edit")
            {
                if (checkData())
                {
                    tbGiaoVien gv = new tbGiaoVien();
                    gv.MaGV = ID;
                    gv.TenGV = txtTenGV.Text;
                    gv.Khoa.TenKhoa =  cbTenKhoa.SelectedItem.ToString();

                   

                    if (gvdao.UpdateGV(gv))
                    {
                        
                        ShowAllGV();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            KhoaControl();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbGiaoVien gv = new tbGiaoVien();
            gv.MaGV = ID;
            if ((gvdao.KiemTraDuLieu(gv.MaGV)) == 1)
            {
                MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá giáo viên này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (gvdao.DeleteGV(gv))
                    {
                        ShowAllGV();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                DataTable dt = gvdao.TimKiem(txtTimKiem.Text);
                if (dt.Rows.Count > 0)
                {
                    listGiaoVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có kết quả tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllGV();
                }
            }
            else
            {
                ShowAllGV();
            }

        }
        

        private void cbTimKiemKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(cbTimKiemKhoa.SelectedItem.ToString()))
            {
                DataTable dt = gvdao.TimKiemTheoKhoa(cbTimKiemKhoa.SelectedItem.ToString());
                if (dt.Rows.Count > 0)
                {
                    listGiaoVien.DataSource = dt;
                }
            }
            else
            {
                ShowAllGV();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                // Hiển thị lại danh sách giáo viên đầy đủ
                ShowAllGV();
            }
            
        }

        private void cbTimKiemKhoa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTimKiemKhoa.Text))
            {
                // Hiển thị lại tất cả danh sách sinh viên
                ShowAllGV();
            }
        }
    }
}
