using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDMHX;
namespace CDMHX
{
    
    class CongViecDAO
    {
        DataTable listCV;
        DataConnection dc;
        public CongViecDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaCV");
            dt.Columns.Add("TenCV");
            
            return dt;
        }

        
        public DataTable GetAllCongViec()
        {

             listCV = createTB();
            
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();
            
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM CongViec";

          
            SqlDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                tbCongViec cv = new tbCongViec();
                // Xử lý dữ liệu lấy được từ công việc

                cv.MaCV = (int)reader["MaCV"];
                cv.TenCV = reader["TenCV"].ToString();
                

               
                
                listCV.Rows.Add(cv.MaCV,cv.TenCV);
               
            }

            reader.Close();
            dc.getConnec().Close();
            return listCV;
        }
        public bool ThemCV(tbCongViec cv1)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_ThemCongViec";
            command.Connection = dc.getConnec();

            SqlParameter maCongViecParam = new SqlParameter("@MaCongViec", SqlDbType.Int);
            maCongViecParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(maCongViecParam);


            command.Parameters.Add("@TenCongViec", SqlDbType.NVarChar).Value = cv1.TenCV;
            

            command.ExecuteNonQuery();
            dc.getConnec().Close();

            return true;
        }


        public bool UpdateCV(tbCongViec cv1)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "UpdateCongViec";
            command.Connection = dc.getConnec();

            // Thêm các tham số và truyền giá trị từ đối tượng cv1
            command.Parameters.Add("@MaCV", SqlDbType.Int).Value = cv1.MaCV;
            command.Parameters.Add("@TenCV", SqlDbType.NVarChar).Value = cv1.TenCV;
            

            // Thực thi câu lệnh
            command.ExecuteNonQuery();
            dc.getConnec().Close();

            return true;
        }


        public bool DeleteCV(tbCongViec cv1)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "XoaCongViec";
            command.Connection = dc.getConnec();

            // Thêm tham số @MaCV và truyền giá trị từ đối tượng cv1
            command.Parameters.Add("@MaCV", SqlDbType.Int).Value = cv1.MaCV;

            // Thực thi câu lệnh
            command.ExecuteNonQuery();
            dc.getConnec().Close();

            return true;
        }
        public int KiemTraDuLieu(int ma)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEUCV] ({0})", ma);
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

        public DataTable TimKiem(string Tukhoa)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SearchCongViec";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbCongViec cv = new tbCongViec();
                // Xử lý dữ liệu lấy được từ công việc

                cv.MaCV = (int)reader["MaCV"];
                cv.TenCV = reader["TenCV"].ToString();
                



                listTimKiem.Rows.Add(cv.MaCV, cv.TenCV);

            }

            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;
        }

    }
}
