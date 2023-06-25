using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class SINHVIEN : Form
    {
        int index = 0;
        string flag;
        SINHVIENDAO svdao = new SINHVIENDAO();
        public SINHVIEN()
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

            txtMaSV.ReadOnly = true;
            txtTenSV.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSDT.ReadOnly = true;
            cbGioiTinh.Enabled = false;
            dateNgaySinh.Enabled = false;
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

            txtMaSV.ReadOnly = true;
            txtTenSV.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            cbGioiTinh.Enabled = true;
            dateNgaySinh.Enabled = true;
            cbTenKhoa.Enabled = true;
            txtTenSV.Focus();

        }
       
        public void ShowAllSV()
        {

            DataTable listCV = svdao.GetAllSV();

            listSinhVien.DataSource = listCV;

        }

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            listSinhVien.AutoGenerateColumns = false;

            KhoaControl();
            ShowAllSV();
            cbTenKhoa.Items.Add("CÔNG NGHỆ THÔNG TIN");
            cbTenKhoa.Items.Add("KINH TẾ");
            cbTenKhoa.Items.Add("VIỄN THÔNG");
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            cbTimKiemKhoa.Items.Add("CÔNG NGHỆ THÔNG TIN");
            cbTimKiemKhoa.Items.Add("KINH TẾ");
            cbTimKiemKhoa.Items.Add("VIỄN THÔNG");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UnlockControl();
           
            flag = "add";
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cbGioiTinh.Text = "";
            cbTenKhoa.Text = "";
            dateNgaySinh.Value = DateTime.Now;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UnlockControl();

            flag = "edit";

            if (txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đối tượng cần sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAllSV();
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

            
            ShowAllSV();
        }
        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTenSV.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenSV.Focus();
                return false;
            }
            if (dateNgaySinh.Value.Year > 2002)
            {
                // Hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Năm sinh phải nhỏ hơn năm 2002!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dateNgaySinh.Focus();
                return false;
            }
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSDT.Focus();
                return false;
            }

            // Kiểm tra số điện thoại có đúng định dạng và có đủ 10-11 chữ số
            Regex regex = new Regex(@"^\d{10,11}$");
            if (!regex.IsMatch(sdt))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập số điện thoại có đúng định dạng và có đủ 10-11 chữ số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return false;
            }
            if(string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbGioiTinh.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbGioiTinh.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbTenKhoa.SelectedItem.ToString()))
            {
                MessageBox.Show("Bạn chưa chọn khoa sinh viên", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbTenKhoa.Focus();
                return false;
            }




            return true;
        }
        int ID;
        private void listSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            index = listSinhVien.CurrentCell.RowIndex;
            DataTable dt = (DataTable)listSinhVien.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                int.TryParse(listSinhVien.Rows[index].Cells[0].Value.ToString(), out ID);
                txtMaSV.Text = ID.ToString();
                txtTenSV.Text = listSinhVien.Rows[index].Cells[1].Value.ToString();
                txtDiaChi.Text = listSinhVien.Rows[index].Cells[4].Value.ToString();
                txtSDT.Text = listSinhVien.Rows[index].Cells[5].Value.ToString();
                cbGioiTinh.Text = listSinhVien.Rows[index].Cells[2].Value.ToString(); // Gán dữ liệu vào ComboBox
                cbTenKhoa.Text = listSinhVien.Rows[index].Cells[6].Value.ToString();
                DateTime ngaySinh;
                DateTime.TryParse(listSinhVien.Rows[index].Cells[3].Value.ToString(), out ngaySinh);
                if (ngaySinh != DateTime.MinValue)
                {
                    dateNgaySinh.Value = ngaySinh;
                }

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    tbSinhVien sv = new tbSinhVien();

                    sv.TenSV = txtTenSV.Text;                                   
                  sv.DiaChi =   txtDiaChi.Text;
                   sv.SDT= txtSDT.Text ;
                    sv.GioiTinh = cbGioiTinh.Text;
                    sv.Khoa.TenKhoa = cbTenKhoa.Text;
                   sv.NgaySinh = dateNgaySinh.Value;
                    if (svdao.ThemSV(sv))
                    {
                        ShowAllSV();
                        KhoaControl();
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
                    tbSinhVien sv = new tbSinhVien();
                    sv.MaSV = ID;
                    sv.TenSV = txtTenSV.Text;
                    sv.DiaChi = txtDiaChi.Text;
                    sv.SDT = txtSDT.Text;
                    sv.GioiTinh = cbGioiTinh.Text;
                    sv.Khoa.TenKhoa = cbTenKhoa.Text;
                    sv.NgaySinh = dateNgaySinh.Value;
                    if (svdao.UpdateSV(sv))
                    {
                        ShowAllSV();
                        KhoaControl();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }


           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbSinhVien sv = new tbSinhVien();
            sv.MaSV = ID;
            if ((svdao.KiemTraDuLieu(sv.MaSV)) == 1)
            {
                MessageBox.Show("Dữ Liệu Này Không Được Xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xoá sinh viên này?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (svdao.DeleteSV(sv))
                    {
                        ShowAllSV();
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
                DataTable dt = svdao.TimKiem(txtTimKiem.Text);
                if (dt.Rows.Count > 0)
                {
                    listSinhVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không có kết quả tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowAllSV();
                }
            }
            else
            {
                ShowAllSV();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                // Hiển thị lại danh sách giáo viên đầy đủ
                ShowAllSV();
            }
        }

        private void cbTimKiemKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbTimKiemKhoa.SelectedItem.ToString()))
            {
                DataTable dt = svdao.TimKiemTheoKhoa(cbTimKiemKhoa.SelectedItem.ToString());
                if (dt.Rows.Count > 0)
                {
                    listSinhVien.DataSource = dt;
                }
            }
            else
            {
                ShowAllSV();
            }
        }

        private void cbTimKiemKhoa_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTimKiemKhoa.Text))
            {
                // Hiển thị lại tất cả danh sách sinh viên
                ShowAllSV();
            }
        }
    }
}
