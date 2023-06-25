using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class GIAOVIENDAO
    {
        
        
            DataTable listGV;
            DataConnection dc;
            public GIAOVIENDAO()
            {
                dc = new DataConnection();
            }
            public DataTable createTB()
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("MaGV");
                dt.Columns.Add("TenGV");
                dt.Columns.Add("Khoa");
                return dt;
            }


            public DataTable GetAllGV()
            {

                listGV = createTB();

                SqlCommand command = new SqlCommand();
                command.Connection = dc.getConnec();

                command.CommandType = CommandType.Text;
                command.CommandText = "select * from V_DSGV";



            SqlDataReader reader = command.ExecuteReader();

                
                while (reader.Read())
                {
                tbGiaoVien gv = new tbGiaoVien();
                    // Xử lý dữ liệu lấy được từ công việc

                    gv.MaGV = (int)reader["MaGV"];
                    gv.TenGV = reader["TenGV"].ToString();
                    gv.Khoa.TenKhoa = (string)reader["TenKhoa"];
                   



                    listGV.Rows.Add(gv.MaGV, gv.TenGV,gv.Khoa.TenKhoa);

                }

                reader.Close();
                dc.getConnec().Close();
                return listGV;
            }
            public bool ThemGV(tbGiaoVien gv1)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_ThemGiaoVien";
                command.Connection = dc.getConnec();

                SqlParameter maCongViecParam = new SqlParameter("@MaGiaoVien", SqlDbType.Int);
                maCongViecParam.Direction = ParameterDirection.Output;
                command.Parameters.Add(maCongViecParam);


                command.Parameters.Add("@TenGiaoVien", SqlDbType.NVarChar).Value = gv1.TenGV;
            command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar).Value = gv1.Khoa.TenKhoa;

            command.ExecuteNonQuery();
                dc.getConnec().Close();

                return true;
            }


            public bool UpdateGV(tbGiaoVien gv1)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_ChinhSuaGiaoVien";
                command.Connection = dc.getConnec();

            // Thêm các tham số và truyền giá trị từ đối tượng cv1
                command.Parameters.Add("@MaGV", SqlDbType.Int).Value = gv1.MaGV;
                command.Parameters.Add("@TenGV", SqlDbType.NVarChar).Value = gv1.TenGV;
                command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar).Value = gv1.Khoa.TenKhoa;
                

                // Thực thi câu lệnh
                command.ExecuteNonQuery();
                dc.getConnec().Close();

                return true;
            }


            public bool DeleteGV(tbGiaoVien gv1)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SP_XoaGiaoVien";
                command.Connection = dc.getConnec();

                // Thêm tham số @MaCV và truyền giá trị từ đối tượng cv1
                command.Parameters.Add("@MaGV", SqlDbType.Int).Value = gv1.MaGV;

                // Thực thi câu lệnh
                command.ExecuteNonQuery();
                dc.getConnec().Close();

                return true;
            }
            

        

            
    
        public List<string> GetKhoaList()
        {
            List<string> khoaList = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_GETTENKHOA";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string tenKhoa = reader["TenKhoa"].ToString();
                khoaList.Add(tenKhoa);
            }

            reader.Close();
            dc.getConnec().Close();
            return khoaList;
        }


        public DataTable TimKiem(string Tukhoa)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TIMKIEMGV";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbGiaoVien gv = new tbGiaoVien();
                // Xử lý dữ liệu lấy được từ công việc

                gv.MaGV = (int)reader["MaGV"];
                gv.TenGV = reader["TenGV"].ToString();
                gv.Khoa.TenKhoa = (string)reader["TenKhoa"];



                listTimKiem.Rows.Add(gv.MaGV, gv.TenGV, gv.Khoa.TenKhoa);

            }

            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;
        }
        public DataTable TimKiemTheoKhoa(string Tukhoa)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_TIMKIEMTHEOKHOA";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbGiaoVien gv = new tbGiaoVien();
                // Xử lý dữ liệu lấy được từ công việc

                tbSinhVien sv = new tbSinhVien();

                gv.MaGV = (int)reader["MaGV"];
                gv.TenGV = reader["TenGV"].ToString();
                gv.Khoa.TenKhoa = (string)reader["TenKhoa"];



                listTimKiem.Rows.Add(gv.MaGV, gv.TenGV, gv.Khoa.TenKhoa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;

        }


    }



}
