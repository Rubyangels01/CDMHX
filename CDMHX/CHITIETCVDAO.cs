using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class CHITIETCVDAO
    {
        DataConnection dc;
        public CHITIETCVDAO()
        {
            dc = new DataConnection();
        }
        public List<string> LayXa(int macd, int magv)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();
            
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ("SP_XA_CTCV");
            command.Parameters.Add("@MACD", SqlDbType.Int).Value= macd;
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = magv;
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
        public List<string> LayAp(string Xa)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT TenAp FROM Ap WHERE MaXa = (SELECT MaXa FROM Xa WHERE TenXa = N'{0}' )", Xa));


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenap = reader["TenAp"].ToString();
                listXa.Add(tenap);

            }


            reader.Close();
            dc.getConnec().Close();
            return listXa;
        }
        public List<string> LayNhom(string Xa,DateTime ngay, string buoi, int maCD)
        {

            List<string> listNhom = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_CTCV_NHOM";
            command.Parameters.Add("@TenXa", SqlDbType.NVarChar).Value = Xa;
            
            command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            command.Parameters.Add("@Buoi", SqlDbType.NVarChar).Value = buoi;
            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tennhom = reader["TenNhom"].ToString();
                listNhom.Add(tennhom);

            }


            reader.Close();
            dc.getConnec().Close();
            return listNhom;
        }

        public List<string> LayNhomDaPC(string Xa, DateTime ngay, string buoi, int maCD)
        {

            List<string> listNhom = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_CTCVDAPC_NHOM";
            command.Parameters.Add("@TenXa", SqlDbType.NVarChar).Value = Xa;
            
            command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
            command.Parameters.Add("@Buoi", SqlDbType.NVarChar).Value = buoi;
            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tennhom = reader["TenNhom"].ToString();
                listNhom.Add(tennhom);

            }


            reader.Close();
            dc.getConnec().Close();
            return listNhom;
        }
        public void PhanCongCV(string tenap, string tencv, DateTime ngay, string buoi, string tennhom)
        {
            
            {
                using (SqlCommand command = new SqlCommand("SP_PHANCONGCV", dc.getConnec()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TenAp", SqlDbType.NVarChar).Value = tenap;
                    command.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = tencv;
                    command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
                    command.Parameters.Add("@Buoi", SqlDbType.NVarChar).Value = buoi;
                    command.Parameters.Add("@TenNhom", SqlDbType.NVarChar).Value = tennhom;
                    try
                    {
                        command.ExecuteNonQuery();
                        
                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi
                        Console.WriteLine("Lỗi: " + ex.Message);
                        
                    }
                }
            }
            
        }

        public void XOACV(string tenap, string tencv, DateTime ngay, string buoi, string tennhom)
        {

            {
                using (SqlCommand command = new SqlCommand("SP_XOA_CTCV", dc.getConnec()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@TenAp", SqlDbType.NVarChar).Value = tenap;
                    command.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = tencv;
                    command.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay;
                    command.Parameters.Add("@Buoi", SqlDbType.NVarChar).Value = buoi;
                    command.Parameters.Add("@TenNhom", SqlDbType.NVarChar).Value = tennhom;
                    try
                    {
                        command.ExecuteNonQuery();

                    }
                    catch (SqlException ex)
                    {
                        // Xử lý lỗi
                        Console.WriteLine("Lỗi: " + ex.Message);

                    }
                }
            }

        }


    }
}
