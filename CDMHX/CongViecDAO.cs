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
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");
            return dt;
        }

        
        public DataTable GetAllCongViec()
        {

             listCV = createTB();
            
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();
            
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetAllCongViec";

          
            SqlDataReader reader = command.ExecuteReader();
            

            while (reader.Read())
            {
                tbCongViec cv = new tbCongViec();
                // Xử lý dữ liệu lấy được từ công việc

                cv.MaCV = (int)reader["MaCV"];
                cv.TenCV = reader["TenCV"].ToString();
                cv.NgayBD = (DateTime)reader["NgayBD"];
                cv.NgayKT = (DateTime)reader["NgayKT"];

               
                
                listCV.Rows.Add(cv.MaCV,cv.TenCV,cv.NgayBD,cv.NgayKT);
               
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
            command.Parameters.Add("@NgayBatDau", SqlDbType.Date).Value = cv1.NgayBD;
            command.Parameters.Add("@NgayKetThuc", SqlDbType.Date).Value = cv1.NgayKT;

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
            command.Parameters.Add("@NgayBD", SqlDbType.Date).Value = cv1.NgayBD;
            command.Parameters.Add("@NgayKT", SqlDbType.Date).Value = cv1.NgayKT;

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
                cv.NgayBD = (DateTime)reader["NgayBD"];
                cv.NgayKT = (DateTime)reader["NgayKT"];



                listTimKiem.Rows.Add(cv.MaCV, cv.TenCV, cv.NgayBD, cv.NgayKT);

            }

            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;
        }

    }
}
