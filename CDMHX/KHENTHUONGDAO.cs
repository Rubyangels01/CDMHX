using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class KHENTHUONGDAO
    {
        DataConnection dc;
        public KHENTHUONGDAO()
        {
            dc = new DataConnection();
        }
        public  DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("Nhom");
            
            return dt;
        }
        public static DataTable createTBSVKT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV2");
            dt.Columns.Add("TenSV2");
            dt.Columns.Add("TenNhom2");
            dt.Columns.Add("TenKT");

            return dt;
        }
        public List<string> LayMaCD()
        {
            List<string> listMaCD = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaCD FROM CDMHX WHERE MaCD >= YEAR(GETDATE())";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string macd = reader["MaCD"].ToString();
                listMaCD.Add(macd);

            }
            reader.Close();
            dc.getConnec().Close();
            return listMaCD;
        }
        public List<string> LayMaKT()
        {
            List<string> listMaKT = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "select MaKT from ThanhTich";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader["MaKT"].ToString();
                listMaKT.Add(makt);

            }
            reader.Close();
            dc.getConnec().Close();
            return listMaKT;
        }

        public string MucDoKT(string MaKT)
        {

            string mdkt = "";

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT MucDoKT FROM ThanhTich WHERE MaKT = N'{0}'", MaKT));


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenXa = reader["MucDoKT"].ToString();
                mdkt = tenXa;

            }


            reader.Close();
            dc.getConnec().Close();
            return mdkt;
        }

        public DataTable GetAllSV(int maCD, string maKT)
        {

            DataTable listSV = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_SV_NHOM";

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@MaKT", SqlDbType.NChar).Value = maKT;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaSV"];
                string TenSV = reader["TenSV"].ToString();
                string TenNhom = reader["TenNhom"].ToString();
                listSV.Rows.Add(MaSV, TenSV, TenNhom);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public DataTable GetAllSVDaKT(int maCD, string maKT)
        {

            DataTable listSV2 = createTBSVKT();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_SVDAKT_NHOM";

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@MaKT", SqlDbType.NChar).Value = maKT;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaSV"];
                string TenSV = reader["TenSV"].ToString();
                string TenNhom = reader["TenNhom"].ToString();
                string TenKT = reader["MaKT"].ToString();
                listSV2.Rows.Add(MaSV, TenSV, TenNhom, TenKT);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV2;
        }
        public void InsertKT(int masv,int maCD, string maKT)
        {          
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_INSERTKT";
            command.Parameters.Add("@MaSV", SqlDbType.Int).Value = masv;
            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@MaKT", SqlDbType.NChar).Value = maKT;
            SqlDataReader reader = command.ExecuteReader();           
            dc.getConnec().Close();         
        }
        public void DeleteSV_KT(int masv, int maCD, string maKT)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DELETE_SV_KT";
            command.Parameters.Add("@MaSV", SqlDbType.Int).Value = masv;
            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@MaKT", SqlDbType.NChar).Value = maKT;
            SqlDataReader reader = command.ExecuteReader();
            dc.getConnec().Close();
        }

    }
}
