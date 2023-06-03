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
