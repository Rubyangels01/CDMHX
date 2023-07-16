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
    public partial class KIEMTRAPC_GV : Form
    {
        DataConnection dc;
        public KIEMTRAPC_GV()
        {
            dc = new DataConnection();
            InitializeComponent();
        }
        
        public int KiemTraDuLieu(string macd, string magv)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEU_GV_GS] ({0}, {1})", macd,magv);
            command.Connection = dc.getConnec();

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
        public int magv;
        private void btnXem_Click(object sender, EventArgs e)
        {
            
            if (KiemTraDuLieu(cbMaCD.Text,txtMaGV.Text) == 1)
            {
                int test = 0;    
                CHITIETCV form = new CHITIETCV();
                
                test = Program.ConvertStringToInt(txtMaGV.Text);
                magv = test;
                
                form.ShowDialog();
            } 
            else
            {
                MessageBox.Show("Bạn chưa có trong danh sách giám sát!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }    
        }

        private void KIEMTRAPC_GV_Load(object sender, EventArgs e)
        {
              
             txtMaGV.Text = "";
            magv = 0;
            cbMaCD.Items.AddRange(Program.LayMaCD().ToArray());
            cbMaCD.SelectedIndex = 0;
        }
    }
}
