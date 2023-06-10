using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class DANGNHAPDAO
    {
        DataConnection dc;
        public DANGNHAPDAO()
        {
            dc = new DataConnection();
        }
        public bool LayThongTinDangNhap(string TaiKhoan, string pass,string role)
        {
            using (SqlCommand command = new SqlCommand("SP_DANGNHAP", dc.getConnec()))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = TaiKhoan;
                command.Parameters.Add("@Password", SqlDbType.NVarChar).Value = pass;
                command.Parameters.Add("@Role", SqlDbType.NVarChar).Value = role;
                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Lỗi hệ thống: " + ex.Message);
                    return false;
                }
            }


        }
    }
}
