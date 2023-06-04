using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class THEMSVNHOMDAO
    {
        DataTable listSV;
        DataConnection dc;
        public THEMSVNHOMDAO()
        {
            dc = new DataConnection();
        }

        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSVNhom");
            dt.Columns.Add("TenSVNhom");
            dt.Columns.Add("GioiTinhSV");

            dt.Columns.Add("TenKhoaNhom");
            return dt;
        }

        public void SaveSVNhom(int MaSV, string TenSV, string GioiTinh, string TenKhoa)
        {
            using (SqlConnection connection = dc.getConnec())
            {
                


                // Kiểm tra xem bảng tạm "" đã tồn tại hay chưa
                string checkTableExistsQuery = "SELECT 1 FROM sys.tables WHERE name = 'SvnhomTemp'";

                using (SqlCommand checkTableExistsCommand = new SqlCommand(checkTableExistsQuery, connection))
                {
                    object result = checkTableExistsCommand.ExecuteScalar();
                    bool tableExists = (result != null && result != DBNull.Value);

                    if (!tableExists)
                    {
                        // Nếu bảng tạm chưa tồn tại, thực hiện tạo bảng tạm
                        string createTableQuery = @"
                    CREATE TABLE SvnhomTemp (
    MaSV INT,
    TenSV NVARCHAR(50),
    GioiTinh NVARCHAR(5),
    TenKhoa NVARCHAR(50)
);
";
                        using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, connection))
                        {
                            createTableCommand.ExecuteNonQuery();
                        }
                    }
                }

                // Thêm dữ liệu vào bảng tạm "#Svnhom"
                string insertDataQuery = @"
            INSERT INTO SvnhomTemp (MaSV, TenSV, GioiTinh, TenKhoa)
VALUES (@MaSV, @TenSV, @GioiTinh, @TenKhoa);";

                using (SqlCommand insertDataCommand = new SqlCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@MaSV", MaSV);
                    insertDataCommand.Parameters.AddWithValue("@TenSV", TenSV);
                    insertDataCommand.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                    insertDataCommand.Parameters.AddWithValue("@TenKhoa", TenKhoa);

                    insertDataCommand.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public DataTable GetAllSvThem()
        {


            listSV = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetViewDataSVNhom";


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbThanhVienNhom tvnhom = new tbThanhVienNhom();
                // Xử lý dữ liệu lấy được từ công việc


                tvnhom.sv.MaSV = (int)reader["MaSV"];
                tvnhom.sv.TenSV = (string)reader["TenSV"];

                tvnhom.sv.Khoa.TenKhoa = (string)reader["TenKhoa"];
                tvnhom.ChucVu = "Không";

                listSV.Rows.Add(tvnhom.sv.MaSV, tvnhom.sv.TenSV, tvnhom.sv.GioiTinh,tvnhom.sv.Khoa.TenKhoa );
            }


            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }
        public bool DeleteSV(tbSinhVien sv)
        {
            using (SqlCommand command = new SqlCommand("SP_XOASVDUOCHON", dc.getConnec()))
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
        public void XoaBangTam()
        {
            using (SqlConnection connection = dc.getConnec())
            {
                string deleteQuery = "DELETE FROM SvnhomTemp";
                using (SqlCommand deleteconnection = new SqlCommand(deleteQuery, connection))
                {


                    // Xoá toàn bộ các phần tử trong bảng SvnhomTemp

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
        }
    }
}
