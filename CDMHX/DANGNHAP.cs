using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDMHX
{
    public partial class DANGNHAP : Form
    {
        private string tenkh = "TV";
        private string mk = "123";
        DANGNHAPDAO dnd = new DANGNHAPDAO();
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {
            rdGiaoVien.Checked = true;
        }
        public bool checkData()
        {

            if (string.IsNullOrWhiteSpace(txtTK.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTK.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMk.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMk.Focus();
                return false;
            }
            


            return true;
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (rdGiaoVien.Checked)
            {
                if (dnd.LayThongTinDangNhap(txtTK.Text, txtMk.Text, rdGiaoVien.Text))
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    RibbonForm1 main = new RibbonForm1();
                    main.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rdSinhVien.Checked)
            {
                if (dnd.LayThongTinDangNhap(txtTK.Text, txtMk.Text, rdSinhVien.Text))
                {
                    MessageBox.Show("Đăng Nhập Thành Công!");
                    RibbonForm1 main = new RibbonForm1();
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra, xin vui lòng thử lại sau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }
    }
}
