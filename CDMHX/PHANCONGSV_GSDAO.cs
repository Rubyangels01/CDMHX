using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class PHANCONGSV_GSDAO
    {
        DataConnection dc;
        public PHANCONGSV_GSDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("TenXa");

            return dt;
        }
        public static DataTable createTBSVGS()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV2");
            dt.Columns.Add("TenSV2");
            dt.Columns.Add("TenXa2");
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
            command.CommandText = "SP_PCGS_XA";
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
       
        public DataTable GetAllSV(int maCD, string maKT)
        {

            DataTable listSV = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_PHANCONGSV_GS";

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
    }
}
