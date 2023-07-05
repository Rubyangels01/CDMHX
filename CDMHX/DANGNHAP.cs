using DevExpress.XtraEditors;
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
    public partial class DANGNHAP : DevExpress.XtraEditors.XtraForm
    {
        MAIN form = new MAIN();
        public DANGNHAP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            
            Program.login = this.txtTK.Text.Trim();
            Program.password = this.txtMK.Text.Trim();
            if (Program.login.Length == 0 || Program.password.Length == 0)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu còn trống");
                return;
            }
            if (Program.ConnectSql() == 1)
            {
                SqlDataReader myReader = Program.ExecSqlDataReader(string.Format("EXEC SP_DANGNHAP '{0}'", Program.login));
                if (myReader != null)
                {
                    if (myReader.Read())
                    {
                        Program.username = myReader.GetString(0);
                        Program.group = myReader.GetString(1);
                        if (Program.group.ToUpper() != "GIAOVIEN" && Program.group.ToUpper() != "SINHVIEN" && Program.group.ToUpper() != "TRUONG" && Program.group.ToUpper() != "GIAMSAT")
                        {
                            MessageBox.Show("Lỗi không thể lấy được thông tin tài khoản");
                            myReader.Close();
                            return;
                        }

                        Program.loginLogin = Program.login;
                       
                        Program.loginPassword = Program.password;
                        MessageBox.Show("Đăng nhập thành công");
                        form.ShowDialog();



                        this.Hide();


                    }
                    myReader.Close();
                }
                else MessageBox.Show("Không thể đọc thông tin đăng nhập");
                
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int cursorPosition = textBox.SelectionStart;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = cursorPosition;
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int cursorPosition = textBox.SelectionStart;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = cursorPosition;
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }
    }
}

