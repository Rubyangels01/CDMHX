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
    public partial class DSKHENTHUONG : Form
    {
        DataConnection dc = new DataConnection();
        SqlConnection connection = new SqlConnection();
        public DSKHENTHUONG()
        {
            connection = dc.getConnec();
            InitializeComponent();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKT");
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("TenNhom");
            dt.Columns.Add("NDKT");

            return dt;
        }
        public void LayMaCD()
        {
            using (SqlCommand command = new SqlCommand("SELECT MaCD FROM CDMHX WHERE MaCD >= YEAR(GETDATE())", connection))
            {
                command.CommandType = CommandType.Text;

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string maNhom = reader["MaCD"].ToString();
                        cbNamCD.Items.Add(maNhom);
                        cbNamCD.SelectedIndex = 0;
                    }
                    reader.Close();
                }
            }
        }
        
        public DataTable GetAllSV(int maCD)
        {

            DataTable listSV = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSSV_KT";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenkt = reader["MucDoKT"].ToString();
                int MaSV = (int)reader["MaSV"];
                string tensv = reader["TenSV"].ToString();
                string TenNhom = reader["TenNhom"].ToString();
                string ndkt = reader["NDKT"].ToString();
                listSV.Rows.Add(tenkt, MaSV, tensv, TenNhom, ndkt);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public void ShowAllSV()
        {
            int namcd;
            int.TryParse(cbNamCD.Text, out namcd);
            DataTable list = GetAllSV(namcd);
            listSVKT.DataSource = list;
        }
        private void DSKHENTHUONG_Load(object sender, EventArgs e)
        {
            LayMaCD();
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                // Hiển thị lại danh sách giáo viên đầy đủ
                ShowAllSV();
            }
        }
        public DataTable TimKiem(string Tukhoa,string macd)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TIMKIEMSVKT";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;
            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = macd;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbSinhVien sv = new tbSinhVien();
                string tenkt = reader["MucDoKT"].ToString();
                int MaSV = (int)reader["MaSV"];
                string tensv = reader["TenSV"].ToString();
                string TenNhom = reader["TenNhom"].ToString();
                string ndkt = reader["NDKT"].ToString();
                listTimKiem.Rows.Add(tenkt, MaSV, tensv, TenNhom, ndkt);              
            }

            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTimKiem.Text))
            {
                DataTable dt = TimKiem(txtTimKiem.Text,cbNamCD.Text);
                if (dt.Rows.Count > 0)
                {
                    listSVKT.DataSource = dt;
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

        private void cbNamCD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            ShowAllSV();
        }
    }
}
