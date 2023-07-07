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
    public partial class frmSaoLuuPhucHoi : Form
    {
        public frmSaoLuuPhucHoi()
        {
            InitializeComponent();
        }

        private void frmSaoLuuPhucHoi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mUAHEXANHDataSet.v_backupsaoluu' table. You can move, or remove it, as needed.
            this.v_backupsaoluuTableAdapter.Fill(this.mUAHEXANHDataSet.v_backupsaoluu);

        }
        private string ShowInputDialog(string title, string prompt)
        {
            Form inputForm = new Form();
            inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            inputForm.MaximizeBox = false;
            inputForm.MinimizeBox = false;
            inputForm.StartPosition = FormStartPosition.CenterScreen;
            inputForm.ClientSize = new Size(300, 120);
            inputForm.Text = title;

            TextBox txtInput = new TextBox();
            txtInput.Size = new Size(200, 23);
            txtInput.Location = new Point(50, 40);

            Button btnOK = new Button();
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Size = new Size(75, 23);
            btnOK.Location = new Point(50, 70);
            btnOK.Text = "OK";

            Button btnCancel = new Button();
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Size = new Size(75, 23);
            btnCancel.Location = new Point(150, 70);
            btnCancel.Text = "Cancel";

            Label lblPrompt = new Label();
            lblPrompt.Text = prompt;
            lblPrompt.Location = new Point(50, 20);
            lblPrompt.Size = new Size(200, 20);

            inputForm.Controls.Add(lblPrompt);
            inputForm.Controls.Add(txtInput);
            inputForm.Controls.Add(btnOK);
            inputForm.Controls.Add(btnCancel);

            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                return txtInput.Text;
            }

            return string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập tên thiết bị

            string backupDeviceName = ShowInputDialog("Nhập tên thiết bị sao lưu:", "Tên thiết bị");
            if (string.IsNullOrEmpty(backupDeviceName))
            {
                // Người dùng đã hủy nhập tên thiết bị
                return;
            }

            // Hiển thị hộp thoại chọn đường dẫn
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Tệp sao lưu (*.bak)|*.bak";
            saveFileDialog.Title = "Chọn đường dẫn cho thiết bị sao lưu";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupDevicePath = saveFileDialog.FileName;


                string createBackupDeviceQuery = $"EXEC sp_addumpdevice 'disk', '{backupDeviceName}', '{backupDevicePath}'";

                using (SqlConnection connection = new SqlConnection(Program.cs))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(createBackupDeviceQuery, connection);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Đã tạo thiết bị sao lưu thành công!");
                
            }
          //  this.v_backupsaoluuBindingSource.Current(this.mUAHEXANHDataSet.v_backupsaoluu);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
              

                string Tenthietbi = ShowInputDialog("Chọn tên thiết bị sao lưu:", "Tên thiết bị");
                if (string.IsNullOrEmpty(Tenthietbi))
                {
                    // Người dùng đã hủy nhập tên thiết bị
                    return;
                }

                string backupQuery = $"BACKUP DATABASE MUAHEXANH TO  {Tenthietbi}";

                using (SqlConnection connection = new SqlConnection(Program.cs))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(backupQuery, connection);
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Sao lưu DB thành công!");

            }

        private void button3_Click(object sender, EventArgs e)
        {
            string Tenthietbi = ShowInputDialog("Chọn tên thiết bị phục hồi:", "Tên thiết bị");
            if (string.IsNullOrEmpty(Tenthietbi))
            {
                // Người dùng đã hủy nhập tên thiết bị
                return;
            }
            string backupQuery = $"USE master;" +
                    $"ALTER DATABASE MUAHEXANH SET SINGLE_USER WITH ROLLBACK IMMEDIATE;" +
                    $"RESTORE DATABASE MUAHEXANH FROM {Tenthietbi} WITH REPLACE;" +
                    $"ALTER DATABASE MUAHEXANH SET MULTI_USER;";


            using (SqlConnection connection = new SqlConnection(Program.cs))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(backupQuery, connection);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Phục hồi DB thành công!");
        }
    }
}
