using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class PHANCONGGS_DAO
    {
        DataConnection dc;
        public PHANCONGGS_DAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaGV");
            dt.Columns.Add("TenGV");
            dt.Columns.Add("MaKhoa");

            return dt;
        }
        public DataTable createTBGS()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaGV1");
            dt.Columns.Add("TenGV1");
            dt.Columns.Add("MaKhoa1");
            dt.Columns.Add("MaXa");

            return dt;
        }
        public DataTable createTBSV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("ChucVu");


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
        public List<string> LayDB()
        {
            List<string> listMaDB = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TenDB FROM DiaBan";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string macd = reader["TenDB"].ToString();
                listMaDB.Add(macd);

            }
            reader.Close();
            dc.getConnec().Close();
            return listMaDB;


        }
        public List<string> LayXa(int macd, string diaban)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_PCBGS_XA";
            command.Parameters.Add("@MACD", SqlDbType.Int).Value = macd;
            command.Parameters.Add("@TENDB", SqlDbType.NVarChar).Value = diaban;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenXa = reader["TenXa"].ToString();
                listXa.Add(tenXa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listXa;
        }
        public DataTable GetAllGV()
        {

            DataTable listSV = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DS_BGS_CHUAPC";
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaGV"];
                string TenSV = reader["TenGV"].ToString();
                string MaKhoa = reader["MaKhoa"].ToString();
                listSV.Rows.Add(MaSV, TenSV, MaKhoa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public DataTable GetAllSV(int maCD, string tenxa)
        {

            DataTable listSV = createTBSV();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT SINHVIEN.MASV, SINHVIEN.TENSV,GIAMSAT_SV.CHUCVU FROM SINHVIEN JOIN GIAMSAT_SV ON GIAMSAT_SV.MASV = SINHVIEN.MASV WHERE GIAMSAT_SV.MACD = {0} AND GIAMSAT_SV.MAXA =(SELECT MAXA FROM XA WHERE TENXA = N'{1}')", maCD, tenxa);
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaSV"];
                string TenSV = reader["TenSV"].ToString();
                string ChucVu = reader["ChucVu"].ToString();
                listSV.Rows.Add(MaSV, TenSV, ChucVu);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public DataTable GetAllGVDAGS(int maCD,string tenxa)
        {

            DataTable listSV = createTBGS();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DS_GV_PC";

            command.Parameters.Add("@MACD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@TENXA", SqlDbType.NVarChar).Value = tenxa;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaGV = (int)reader["MaGV"];
                string TenGV = reader["TenGV"].ToString();
                string MaKhoa = reader["MaKhoa"].ToString();
                string MaXa = reader["MaXa"].ToString();
                listSV.Rows.Add(MaGV, TenGV, MaKhoa, MaXa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public void Insert_BGS(string magv, string masv)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_INSERT_BGS";
            command.Parameters.Add("@MaGV", SqlDbType.Int).Value = magv;
            command.Parameters.Add("@MaSV", SqlDbType.Int).Value = masv;

            SqlDataReader reader = command.ExecuteReader();
            dc.getConnec().Close();
        }
        public void Delete_GVGS(string magv, string masv)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "";
            command.Parameters.Add("@MaGV", SqlDbType.Int).Value = magv;
            command.Parameters.Add("@MaSV", SqlDbType.Int).Value = masv;

            SqlDataReader reader = command.ExecuteReader();
            dc.getConnec().Close();
        }
        public int KiemTraDuLieu(string maSV,string magv)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEUCT_GS] ({0}, {1})", maSV,magv);
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
    }
}
