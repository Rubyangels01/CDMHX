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
        public List<tbXa> LayXa(int macd,int mags)
        {

            List<tbXa> listXa = new List<tbXa>();

            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            if (Program.loginLogin.Equals("GIAOVIEN") || Program.loginLogin.Equals("TRUONG"))
            {
                command.CommandText = "XA_GS_BAOCAO";
                command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
                command.Parameters.Add("@MAGV", SqlDbType.Int).Value = mags;
            }
            else if (Program.loginLogin.Equals("GIAMSAT"))
            {
                command.CommandText = "XA_GSSV_BAOCAO";
                command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
                command.Parameters.Add("@MASV", SqlDbType.Int).Value = mags;
            }
            
            
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbXa xa = new tbXa();
                string maxa = reader["MaXa"].ToString();
                string tenXa = reader["TenXa"].ToString();
                xa.maxa = maxa;
                xa.tenxa = tenXa;
                listXa.Add(xa);

            }


            reader.Close();
            Program.dc.getConnec().Close();
            return listXa;
        }
        public List<tbDiaBan> LayDiaBan(string maxa)
        {

            List<tbDiaBan> listXa = new List<tbDiaBan>();

            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

                command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT DIABAN.MaDB, DIABAN.TenDB FROM XA,DIABAN WHERE DIABAN.MADB = XA.MADB AND XA.MaXa = {0}",maxa);
                
            


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                
                string madb = reader["MaDB"].ToString();
                string tendb = reader["TenDB"].ToString();
                tbDiaBan db = new tbDiaBan(madb,tendb);
                
                listXa.Add(db);

            }


            reader.Close();
            Program.dc.getConnec().Close();
            return listXa;
        }
        KIEMTRAGS_BAOCAO parentForm = Application.OpenForms.OfType<KIEMTRAGS_BAOCAO>().FirstOrDefault();
        private void BAOCAO_Load(object sender, EventArgs e)
        {
            
            cbXa.DataSource = LayXa(DateTime.Now.Year,parentForm.mags);
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
            cbDiaBan.DataSource = LayDiaBan(cbXa.SelectedValue.ToString());
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";

        }
        
        public void BaoCao(string maxa,string macd, string noidung)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("UPDATE GIAMSAT_SV SET NOIDUNG = N'{0}' WHERE MACD = {1} AND MAXA = {2}",noidung,macd,maxa));
            
            SqlDataReader reader = command.ExecuteReader();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
           if(!string.IsNullOrEmpty(txtNoiDung.Text))
            {
                BaoCao(cbXa.SelectedValue.ToString(),DateTime.Now.Year.ToString(),txtNoiDung.Text);
                MessageBox.Show("Báo cáo thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNoiDung.Text = "";
            } 
           else
            {
                MessageBox.Show("Vui lòng nhập nội dung!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }    
        }

        private void cbXa_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            cbDiaBan.DataSource = LayDiaBan(cbXa.SelectedValue.ToString());
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            */
        }
    }
}
