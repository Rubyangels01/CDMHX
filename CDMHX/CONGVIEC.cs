using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CDMHX
{
    public partial class CONGVIEC : Form
    {
        int index = 0;
        string flag;
        CongViecDAO cvdao = new CongViecDAO();
        public CONGVIEC()
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

            txtTenCV.ReadOnly = true;
            

            btnThem.Focus();
        }


        public void UnlockControl()
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;


            txtTenCV.ReadOnly = false;
           
            txtTenCV.Focus();

        }

        public void ShowAllCV()
        {

            DataTable listCV = cvdao.GetAllCongViec();

            listCongViec.DataSource = listCV;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void CONGVIEC_Load(object sender, EventArgs e)
        {
            KhoaControl();
            ShowAllCV();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "add";
            txtTenCV.Text = "";
            


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            KhoaControl();

            txtTenCV.Text = "";
          
        }
        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTenCV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên công việc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenCV.Focus();
                return false;
            }
            /*
            if (dateNgayBD.Value.Date > dateNgayKT.Value.Date)
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgayBD.Focus();
                return false;
            }*/


            return true;
        }
        int ID;
        private void listCongViec_SelectionChanged(object sender, EventArgs e)
        {
            index = listCongViec.CurrentCell.RowIndex;
            DataTable dt = (DataTable)listCongViec.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                int.TryParse(listCongViec.Rows[index].Cells[0].Value.ToString(), out ID);
                txtTenCV.Text = listCongViec.Rows[index].Cells[1].Value.ToString();
                
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();
            flag = "edit";
            if (txtTenCV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllCV();
                KhoaControl();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    tbCongViec cv = new tbCongViec();
                    
                    cv.TenCV = txtTenCV.Text;
                    
                    if (cvdao.ThemCV(cv))
                    {
                        ShowAllCV();
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
                    tbCongViec cv = new tbCongViec();
                    cv.MaCV = ID;
                    cv.TenCV = txtTenCV.Text;
                    

                    if (cvdao.UpdateCV(cv))
                    {
                        ShowAllCV();
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
            tbCongViec cv = new tbCongViec();
            cv.MaCV = ID;
           
            if ((cvdao.KiemTraDuLieu(cv.MaCV)) == 1)
            {
                MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá công việc này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (cvdao.DeleteCV(cv))
                    {
                        ShowAllCV();
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
                DataTable dt = cvdao.TimKiem(txtTimKiem.Text);
                if (dt.Rows.Count > 0)
                {
                    listCongViec.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có kết quả tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllCV();
                }
            }
            else
            {
                ShowAllCV();
            }
        }

    }
}
