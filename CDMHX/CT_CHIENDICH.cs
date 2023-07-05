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
    public partial class CT_CHIENDICH : Form
    {
        CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();
        
        CT_CDDAO ctcddao = new CT_CDDAO();
        public CT_CHIENDICH()
        {
            InitializeComponent();
        }
        public void ShowAllCV()
        {
            

            DataTable listCT_CVCD = ctcddao.GetAllCongViec(parentForm.MaCD1);

            listCongViec.DataSource = listCT_CVCD;

        }
        public void ShowAllNhom()
        {
            
            
            DataTable listCT_NHOMCD = ctcddao.GetAllNhom(parentForm.MaCD1);

            listNhom.DataSource = listCT_NHOMCD;

        }

        public void ShowAllDB()
        {
            
            DataTable listCT_NHOMCD = ctcddao.GetAllDB(parentForm.MaCD1);

            listDB.DataSource = listCT_NHOMCD;

        }
        public void ShowAllKT()
        {
            

            DataTable listCT_NHOMCD = ctcddao.GetAllKT(parentForm.MaCD1);

            listKT.DataSource = listCT_NHOMCD;

        }
        
        public DataTable GetAllDSSV_GS(int macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC DSSV_GS @MACD = {0}", macd), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;
        }
        public  string LayNoiDung(int macd,string maxa)
        {
            string listnd ="";
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT NOIDUNG FROM GIAMSAT_SV WHERE MACD = {0} AND MAXA = {1}",macd,maxa));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                string noidung = reader["NOIDUNG"].ToString();
                listnd = noidung;
               

            }
            reader.Close();
            Program.dc.getConnec().Close();
            return listnd;


        }
        public List<tbXa> LayXa(int macd,string madb)
        {
            List<tbXa> listxa = new List<tbXa>();
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT XA.MaXa, Xa.TenXa FROM GIAMSAT_SV,Xa,DiaBan WHERE  Xa.MAXA = GIAMSAT_SV.MAXA and xa.MaDB = DiaBan.MaDB AND MACD = {0} AND XA.MADB = {1} group by  XA.MaXa, Xa.TenXa having count(Xa.Maxa) >= 1", macd,madb));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbXa xa = new tbXa();
                string maxa = reader["MaXa"].ToString();
                string tenxa = reader["TenXa"].ToString();
                xa.maxa = maxa;
                xa.tenxa = tenxa;
                listxa.Add(xa);


            }
            reader.Close();
            Program.dc.getConnec().Close();
            return listxa;


        }
        private void CT_CHIENDICH_Load(object sender, EventArgs e)
        {
            ShowAllCV();
            ShowAllNhom();
            ShowAllDB();
            ShowAllKT();
            listGVGS.DataSource = ctcddao.GetAllDSGV_GS(parentForm.MaCD1);
            listSVGS.DataSource = GetAllDSSV_GS(parentForm.MaCD1);
            cbDiaBan.DataSource = Program.LayDB();
            cbDiaBan.DisplayMember = "TenDB";
            cbDiaBan.ValueMember = "MaDB";
            cbXa.DataSource = LayXa(parentForm.MaCD1, cbDiaBan.SelectedValue.ToString());
            cbXa.DisplayMember = "tenxa";
            cbXa.ValueMember = "maxa";
             
            
        }
        
        private void CT_CHIENDICH_FormClosed(object sender, FormClosedEventArgs e)
        {
            CHIENDICH parentForm = Application.OpenForms.OfType<CHIENDICH>().FirstOrDefault();
            if (parentForm != null)
            {
                parentForm.isDetailFormOpen = false;
                
            }
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        public DataTable TimKiemGS_SV(int macd, string tukhoa)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC TIMKIEMDSSV_GS @MACD = {0}, @TUKHOA = N'{1}'", macd, tukhoa), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;

        }
        public DataTable TimKiemGS_GV(int macd, string tukhoa)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC TIMKIEMDSGV_GS @MACD = {0}, @TUKHOA = N'{1}'", macd, tukhoa), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            listSVGS.DataSource = TimKiemGS_SV(parentForm.MaCD1, txtTimKiem.Text);
            listGVGS.DataSource = TimKiemGS_GV(parentForm.MaCD1, txtTimKiem.Text);
            if (listSVGS.Rows.Count == 1 && listGVGS.Rows.Count == 1)
            {
                MessageBox.Show("Không tìm thấy dữ liệu!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Text))
            {
                listGVGS.DataSource =ctcddao.GetAllDSGV_GS(parentForm.MaCD1);
                listSVGS.DataSource = GetAllDSSV_GS(parentForm.MaCD1);
            }    
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(cbXa.Text == "Danh Sách Rỗng")
            {
                MessageBox.Show("Địa Bàn Chưa Tồn Tại Giám Sát!","THÔNG BÁO",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                txtChiTietBaoCao.Text = LayNoiDung(parentForm.MaCD1, cbXa.SelectedValue.ToString());
            }    
            
        }

        private void cbDiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LayXa(parentForm.MaCD1, cbDiaBan.SelectedValue.ToString()).Count == 0)
            {
                cbXa.DataSource = null;
                cbXa.Items.Add("Danh Sách Rỗng");
                cbXa.SelectedItem = "Danh Sách Rỗng";
            }
            else
            {
                cbXa.DataSource = LayXa(parentForm.MaCD1, cbDiaBan.SelectedValue.ToString());
                cbXa.DisplayMember = "tenxa";
                cbXa.ValueMember = "maxa";
            }
        }
    }
}
