using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class SINHVIENDAO
    {
        DataTable listSV;
        DataConnection dc;
        public SINHVIENDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("Sdt");
            dt.Columns.Add("TenKhoa");
            return dt;
        }


        public DataTable GetAllSV()
        {

            listSV = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from V_DSSV";


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbSinhVien sv = new tbSinhVien();
                // Xử lý dữ liệu lấy được từ công việc

                sv.MaSV = (int)reader["MaSV"];
                sv.TenSV = reader["TenSV"].ToString();
                sv.GioiTinh = reader["GioiTinh"].ToString();
                sv.SDT = reader["SoDT"].ToString();
                sv.NgaySinh = (DateTime)reader["NgaySinh"];
                sv.DiaChi = reader["DiaChi"].ToString();          
                sv.Khoa.TenKhoa = (string)reader["TenKhoa"];


                listSV.Rows.Add(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.DiaChi, sv.SDT, sv.Khoa.TenKhoa);
            }


            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public bool ThemSV(tbSinhVien sv)
        {
            using (SqlCommand command = new SqlCommand("SP_ThemSinhVien", dc.getConnec()))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar).Value = sv.TenSV;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sv.NgaySinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = sv.Khoa.MaKhoa;

                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Lỗi khi thêm sinh viên: " + ex.Message);
                    return false;
                }
            }
        }



        public bool UpdateSV(tbSinhVien sv)
        {
            using (SqlCommand command = new SqlCommand("SP_ChinhSuaSinhVien", dc.getConnec()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;
                command.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar).Value = sv.TenSV;
                command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                command.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = sv.NgaySinh;
                command.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                command.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = sv.Khoa.MaKhoa;

                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Lỗi khi cập nhật sinh viên: " + ex.Message);
                    return false;
                }
            }
        }


        public bool DeleteSV(tbSinhVien sv)
        {
            using (SqlCommand command = new SqlCommand("SP_XoaSinhVien", dc.getConnec()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@MaSV", SqlDbType.NVarChar).Value = sv.MaSV;                           
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Lỗi khi xoá sinh viên: " + ex.Message);
                    return false;
                }
            }
        }    
        public DataTable TimKiem(string Tukhoa)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TIMKIEMSV";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbSinhVien sv = new tbSinhVien();
                
                sv.MaSV = (int)reader["MaSV"];
                sv.TenSV = reader["TenSV"].ToString();
                sv.GioiTinh = reader["GioiTinh"].ToString();
                sv.SDT = reader["SoDT"].ToString();
                sv.NgaySinh = (DateTime)reader["NgaySinh"];
                sv.DiaChi = reader["DiaChi"].ToString();
                sv.Khoa.TenKhoa = (string)reader["TenKhoa"];



                listTimKiem.Rows.Add(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.DiaChi, sv.SDT, sv.Khoa.TenKhoa);

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
            command.CommandText = "SP_TIMKIEMSVTHEOKHOA";
            command.Parameters.Add("@TuKhoa", SqlDbType.Char).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbGiaoVien gv = new tbGiaoVien();
                // Xử lý dữ liệu lấy được từ công việc

                tbSinhVien sv = new tbSinhVien();

                sv.MaSV = (int)reader["MaSV"];
                sv.TenSV = reader["TenSV"].ToString();
                sv.GioiTinh = reader["GioiTinh"].ToString();
                sv.SDT = reader["SoDT"].ToString();
                sv.NgaySinh = (DateTime)reader["NgaySinh"];
                sv.DiaChi = reader["DiaChi"].ToString();
                sv.Khoa.TenKhoa = (string)reader["TenKhoa"];



                listTimKiem.Rows.Add(sv.MaSV, sv.TenSV, sv.GioiTinh, sv.NgaySinh, sv.DiaChi, sv.SDT, sv.Khoa.TenKhoa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;

        }
        public int KiemTraDuLieu(int ma)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEUSV] ({0})", ma);
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
