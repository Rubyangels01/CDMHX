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
    public partial class KIEMTRAGS_BAOCAO : Form
    {
        public KIEMTRAGS_BAOCAO()
        {
            InitializeComponent();
        }
        public int KiemTraDuLieu(string macd, string mags)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            if (Program.loginLogin == "GIAOVIEN" || Program.loginLogin == "TRUONG")
            {
                command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEU_GV_GS] ({0}, {1})", macd, mags);
            }
            else if (Program.loginLogin == "GIAMSAT")
            {
                command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEU_SV_GS] ({0}, {1})", macd, mags);
            }
            
            command.Connection = Program.dc.getConnec();

            int kq = 0;

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    kq = reader.GetInt32(0);
                }
            }

            command.Connection.Close();

            return kq;
        }
        private void KIEMTRAGS_BAOCAO_Load(object sender, EventArgs e)
        {
            txtNamCd.Text = DateTime.Now.Year.ToString();
            if (Program.loginLogin == "GIAOVIEN" || Program.loginLogin == "TRUONG")
            {
                labelMaGS.Text = "MÃ GIÁO VIÊN";
            }  
            else if(Program.loginLogin == "GIAMSAT")
            {
                labelMaGS.Text = "MÃ SINH VIÊN";
            }
            
        }
        public int mags = 0;
        private void btnXem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaGS.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mã giám sát của bạn!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if(KiemTraDuLieu(txtNamCd.Text,txtMaGS.Text) == 1)
                {
                    BAOCAO form = new BAOCAO();
                    int.TryParse(txtMaGS.Text, out mags);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bạn chưa có trong danh sách giám sát!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
        }
    }
}
