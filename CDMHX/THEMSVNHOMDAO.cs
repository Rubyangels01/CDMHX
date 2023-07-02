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

        public DataTable createTBSVNhom()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSVNhom");
            dt.Columns.Add("TenSVNhom");
            dt.Columns.Add("GioiTinhSV");

            dt.Columns.Add("TenKhoaNhom");
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("ChucVu");
            return dt;
        }
        public static DataTable createTBSV()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("TenKhoa");

            return dt;
        }
        public List<string> LayMaCD()
        {
            List<string> listMaCD = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT MaCD FROM CDMHX WHERE MaCD >= YEAR(GETDATE())";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string macd = reader["MaCD"].ToString();
                listMaCD.Add(macd);

            }
            reader.Close();
            dc.getConnec().Close();
            return listMaCD;
        }
        public DataTable GetAllSV(int maCD, string maKT)
        {

            DataTable listSV = createTBSV();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_SV_CHUACONHOM";

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaSV"];
                string TenSV = reader["TenSV"].ToString();
                string GioiTinh = reader["GioiTinh"].ToString();
                string TenKhoa = reader["MaKhoa"].ToString();
                listSV.Rows.Add(MaSV, TenSV, GioiTinh, TenKhoa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV;
        }

        public DataTable GetAllSVDaCoNhom(int maCD)
        {

            DataTable listSV2 = createTBSVNhom();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "DS_SV_DACONHOM";

            command.Parameters.Add("@MaCD", SqlDbType.Int).Value = maCD;
            
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int MaSV = (int)reader["MaSV"];
                string TenSV = reader["TenSV"].ToString();
                string GioiTinh = reader["GioiTinh"].ToString();
                string TenKhoa = reader["MaKhoa"].ToString();
                string MaNhom = reader["MaNhom"].ToString();
                string ChucVu = reader["ChucVu"].ToString();
                listSV2.Rows.Add(MaSV, TenSV, GioiTinh, TenKhoa, MaNhom, ChucVu);

            }
            reader.Close();
            dc.getConnec().Close();
            return listSV2;
        }
        public string manhom;
        public void InsertNhom(string tennhom, string soluong, string macd, string tenap)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_INSERTNHOM";

            command.Parameters.Add("@TENNHOM", SqlDbType.NVarChar).Value = tennhom;
            command.Parameters.Add("@SOLUONG", SqlDbType.Int).Value = Program.ConvertStringToInt(soluong);
            command.Parameters.Add("@MACD", SqlDbType.Int).Value = Program.ConvertStringToInt(macd);
            command.Parameters.Add("@TENAP", SqlDbType.NVarChar).Value = tenap;

            SqlParameter outputParameter = new SqlParameter("@MaNhom", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;
            command.Parameters.Add(outputParameter);

            command.ExecuteNonQuery();

             manhom = outputParameter.Value.ToString();

            dc.getConnec().Close();

            
        }


        public void InsertSV(string manhom,string masv, string chucvu)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;       

            command.CommandText = "SP_INSERTSV_NHOM";
            command.Parameters.Add("@MANHOM", SqlDbType.Int).Value = manhom;
            command.Parameters.Add("@MASV", SqlDbType.Int).Value = masv;
            command.Parameters.Add("@CHUCVU", SqlDbType.NVarChar).Value = chucvu;
            
            SqlDataReader reader = command.ExecuteReader();
            
            dc.getConnec().Close();
            
        }
        public List<string> LayDB()
        {
            List<string> listMaDB = new List<string>();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT TenDB FROM DiaBan";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string macd = reader["TenDB"].ToString();
                listMaDB.Add(macd);

            }
            reader.Close();
            dc.getConnec().Close();
            return listMaDB;


        }
        public List<string> LayXa(string diaban)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT TENXA FROM XA WHERE MADB = (SELECT MADB FROM DIABAN WHERE TENDB = N'{0}')", diaban));
           
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
        public List<string> LayAp(string xa)
        {

            List<string> listXa = new List<string>();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = (string.Format("SELECT TENAP FROM AP WHERE MAXA = (SELECT MAXA FROM XA WHERE TENXA = N'{0}')", xa));

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string tenXa = reader["TenAp"].ToString();
                listXa.Add(tenXa);

            }
            reader.Close();
            dc.getConnec().Close();
            return listXa;
        }
        public DataTable GetAllSvThem()
        {


            listSV = createTBSV();
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
