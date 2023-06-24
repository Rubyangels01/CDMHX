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

        public DataTable GetAllSV(int maCD, int maKT)
        {

            DataTable listSV = new DataTable();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_SV_NHOM";

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            command.Parameters.Add("@MaKT", SqlDbType.Int).Value = maKT;
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
