using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class NHOMDAO
    {
        DataTable listNhom;
        DataTable listSVNhom;
        DataConnection dc;
        public NHOMDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTBNhom()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("TenNhom");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("TenCD");
           
            return dt;
        }
        public DataTable createTBSV()
        {
            DataTable dt = new DataTable();
           
            dt.Columns.Add("MaSV");
            dt.Columns.Add("TenSV");         
            dt.Columns.Add("TenKhoa");
            dt.Columns.Add("ChucVu");
            
            return dt;
        }
        /*
        public void saveNhom()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SaveNhom";
            command.Parameters.Add("@MaNhom", SqlDbType.Int).Value = maNhom;
            dc.getConnec().Close();
        }*/
        public DataTable GetAllNhom()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from V_DSNHOM", dc.getConnec());
            da.Fill(dt);
            dc.getConnec().Close();
            return dt;
            
        }
        public DataTable GetAllNhom_SV(string macd)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(string.Format("SELECT MaNhom,TenNhom,SoLuongSV,CDMHX.TenCD,Ap.TenAp FROM NhomSV,CDMHX,Ap WHERE NhomSV.MaCD = CDMHX.MaCD AND NhomSV.MaAp = Ap.MaAp AND NhomSV.MACD = {0}", macd), dc.getConnec());
            da.Fill(dt);
            dc.getConnec().Close();
            return dt;

        }
        public DataTable GetAllSVNhom(int maNhom)
        {

            listSVNhom = createTBSV();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetAllSVNhom";
            command.Parameters.Add("@MaNhom", SqlDbType.Int).Value = maNhom;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbThanhVienNhom tvnhom = new tbThanhVienNhom();
                // Xử lý dữ liệu lấy được từ công việc

               
                tvnhom.sv.MaSV = (int)reader["MaSV"];
                tvnhom.sv.TenSV = (string)reader["TenSV"];
                tvnhom.sv.Khoa.TenKhoa = (string)reader["TenKhoa"];
                tvnhom.ChucVu = (string)reader["ChucVu"];

                listSVNhom.Rows.Add( tvnhom.sv.MaSV, tvnhom.sv.TenSV, tvnhom.sv.Khoa.TenKhoa, tvnhom.ChucVu);
            }


            reader.Close();
            dc.getConnec().Close();
            return listSVNhom;
        }
        public DataTable GetAllSvThemNhom()
        {


            listSVNhom = createTBSV();
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

                listSVNhom.Rows.Add(tvnhom.sv.MaSV, tvnhom.sv.TenSV, tvnhom.sv.Khoa.TenKhoa,tvnhom.ChucVu);
            }


            reader.Close();
            dc.getConnec().Close();
            return listSVNhom;
        }
    }
}
