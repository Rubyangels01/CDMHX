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
    public partial class BAOCAO : Form
    {
        
        public BAOCAO()
        {
            
            InitializeComponent();
        }
        public List<string> LayXa(int macd)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ("XA_GS_BAOCAO");
            command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
            
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenXa = reader["TenXa"].ToString();
                listXa.Add(tenXa);

            }


            reader.Close();
            Program.dc.getConnec().Close();
            return listXa;
        }
        private void BAOCAO_Load(object sender, EventArgs e)
        {
            cbXa.Items.AddRange(LayXa(DateTime.Now.Year).ToArray());
            cbXa.SelectedIndex = 0;
        }
        public void BaoCao(string tenxa,string macd, string noidung)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ("SP_BAOCAO");
            command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
            command.Parameters.Add("@NOIDUNG", SqlDbType.Text).Value = noidung;
            command.Parameters.Add("@TENXA", SqlDbType.NVarChar).Value = tenxa;
            SqlDataReader reader = command.ExecuteReader();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtNoiDung.Text))
            {
                BaoCao(cbXa.Text,DateTime.Now.Year.ToString(),txtNoiDung.Text);
                MessageBox.Show("Báo cáo thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDung.Text = "";
            } 
           else
            {
                MessageBox.Show("Vui lòng nhập nội dung!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }
    }
}
