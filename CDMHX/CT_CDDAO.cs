using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class CT_CDDAO
    {
        DataTable listCT_CD;
        DataTable listCTNHom_CD;
        DataTable listCTDiaban_CD;
        DataTable listCTKT_CD;
        DataConnection dc;
        public CT_CDDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCV");
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("Buoi");
            dt.Columns.Add("Ngay");
            dt.Columns.Add("TenAp");
            return dt;
        }
        public DataTable createTBNhom()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhomSV");
            dt.Columns.Add("TenNhom");
            dt.Columns.Add("SoLuong");
            
            return dt;
        }
        public DataTable createTBDB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaDB");
            dt.Columns.Add("TenDB");
           

            return dt;
        }
        public DataTable createTBKT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaKT");
            dt.Columns.Add("MucDoKT");
            dt.Columns.Add("NoiDung");
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            return dt;
        }
        public DataTable GetAllCongViec(int maCD)
        {
           
            listCT_CD = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSCV_CD";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
               
                // Xử lý dữ liệu lấy được từ công việc

                int MaNhom = (int)reader["MaNhom"];
                string TenCV = reader["TenCV"].ToString();
               string buoi = reader["Buoi"].ToString();
               DateTime Ngay = (DateTime)reader["Ngay"];
                string ap = reader["TenAp"].ToString();



                listCT_CD.Rows.Add(TenCV,MaNhom, buoi, Ngay, ap);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCT_CD;
        }
        public DataTable GetAllNhom(int maCD)
        {

            listCTNHom_CD = createTBNhom();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSNHOM_CD";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                // Xử lý dữ liệu lấy được từ công việc

                int MaNhom = (int)reader["MaNhom"];
                string TenCV = reader["TenNhom"].ToString();
                
                int sl =(int) reader["SoLuongSV"];



                listCTNHom_CD.Rows.Add(MaNhom, TenCV, sl);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCTNHom_CD;
        }
       
        public DataTable GetAllDB(int maCD)
        {

            listCTDiaban_CD = createTBDB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSDIABAN_CD";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {

                // Xử lý dữ liệu lấy được từ công việc

                int MaDB = (int)reader["MaDB"];
                string TenDB = reader["TenDB"].ToString();

               



                listCTDiaban_CD.Rows.Add(MaDB, TenDB);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCTDiaban_CD;
        }
        public DataTable GetAllKT(int maCD)
        {

            listCTKT_CD = createTBKT();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSKT_CD";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
            
                string MaKT = reader["MaKT"].ToString();
                string MucDoKT = reader["MucDoKT"].ToString();
                string NDKT = reader["NDKT"].ToString();
                string MaSV = reader["MaSV"].ToString();
                string TenSV = reader["TenSV"].ToString();
                listCTKT_CD.Rows.Add(MaKT, MucDoKT, NDKT, MaSV, TenSV);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCTKT_CD;
        }

        public DataTable GetAllDSGV_GS(int macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("EXEC DS_GVGS @MACD = {0}", macd), Program.dc.getConnec());
            da.Fill(dt);
            Program.dc.getConnec().Close();
            return dt;
        }

    }
}
