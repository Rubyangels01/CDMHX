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
        public List<tbXa> LayXa(int macd, int magv)
        {

            List<tbXa> listXa = new List<tbXa>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();
            
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = ("SP_XA_CTCV");
            command.Parameters.Add("@MACD", SqlDbType.Int).Value= macd;
            command.Parameters.Add("@MAGV", SqlDbType.Int).Value = magv;
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
            dc.getConnec().Close();
            return listXa;
        }
        public List<Ap> LayAp(string maxa)
        {

            List<Ap> listAp = new List<Ap>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XA_CTCV";
            command.Parameters.Add("@MAXA", SqlDbType.Int).Value = Program.ConvertStringToInt(maxa);

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
               
                string tenap = reader["TenAp"].ToString();
                string maap = reader["MaAp"].ToString();
                Ap ap = new Ap(maap,tenap);
                listAp.Add(ap);

            }


            reader.Close();
            dc.getConnec().Close();
            return listAp;
        }

        public List<tbDiaBan> LayDB(string maxa)
        {
            List<tbDiaBan> listdb = new List<tbDiaBan>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DB_CTCV";
            command.Parameters.Add("@MAXA", SqlDbType.Int).Value = Program.ConvertStringToInt(maxa);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string madb = reader["MaDB"].ToString();
                string tendb = reader["TenDB"].ToString();
                tbDiaBan db = new tbDiaBan(madb, tendb);
                listdb.Add(db);
            }
            reader.Close();
            dc.getConnec().Close();
            return listdb;           
        }
        public List<string> LayNhom(string Xa,DateTime ngay, string buoi, int maCD)
        {

            List<string> listNhom = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_CTCV_NHOM";
            command.Parameters.Add("@MaXa", SqlDbType.Int).Value = Program.ConvertStringToInt(Xa);

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
            command.Parameters.Add("MaXa", SqlDbType.Int).Value = Program.ConvertStringToInt(Xa);

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
        public void PhanCongCV(string maap, string macv, DateTime ngay, string buoi, string tennhom)
        {
            
            {
                using (SqlCommand command = new SqlCommand("SP_PHANCONGCV", dc.getConnec()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaAp", SqlDbType.Int).Value = Program.ConvertStringToInt(maap);
                    command.Parameters.Add("@MaCV", SqlDbType.Int).Value = Program.ConvertStringToInt(macv);
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

        public void XOACV(string maap, string macv, DateTime ngay, string buoi, string tennhom)
        {

            {
                using (SqlCommand command = new SqlCommand("SP_XOA_CTCV", dc.getConnec()))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaAp", SqlDbType.Int).Value = Program.ConvertStringToInt(maap);
                    command.Parameters.Add("@MaCV", SqlDbType.Int).Value = Program.ConvertStringToInt(macv);
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
