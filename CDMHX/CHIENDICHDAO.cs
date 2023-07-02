using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class CHIENDICHDAO
    {
        DataTable listCD;
        DataConnection dc;
        public CHIENDICHDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MaCD");
            dt.Columns.Add("TenCD");
            dt.Columns.Add("NgayBD");
            dt.Columns.Add("NgayKT");
            return dt;
        }
        public DataTable GetAllCD()
        {

            listCD = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DANHSACH_CD";


            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbChienDich cd = new tbChienDich();
                // Xử lý dữ liệu lấy được từ công việc

                cd.MaCD = (int)reader["MaCD"];
                cd.TenCD = reader["TenCD"].ToString();
                cd.NgayBD = (DateTime)reader["NgayBD"];
                cd.NgayKT = (DateTime)reader["NgayKT"];



                listCD.Rows.Add(cd.MaCD, cd.TenCD, cd.NgayBD, cd.NgayKT);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCD;
        }
        public DataTable TimKiem(string Tukhoa)
        {
            DataTable listTimKiem = createTB();
            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_TIMKIEM_CD";
            command.Parameters.Add("@TuKhoa", SqlDbType.NVarChar).Value = Tukhoa;

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                tbChienDich cd = new tbChienDich();
                // Xử lý dữ liệu lấy được từ công việc

                cd.MaCD = (int)reader["MaCD"];
                cd.TenCD = reader["TenCD"].ToString();
                cd.NgayBD = (DateTime)reader["NgayBD"];
                cd.NgayKT = (DateTime)reader["NgayKT"];



                listTimKiem.Rows.Add(cd.MaCD, cd.TenCD, cd.NgayBD, cd.NgayKT);

            }

            reader.Close();
            dc.getConnec().Close();
            return listTimKiem;
        }

        public void DeleteCD(string macd)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Program.dc.getConnec();

            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("DELETE CDMHX WHERE MACD = {0}", macd);


            SqlDataReader reader = command.ExecuteReader();
        }
        public int KiemTraDuLieu(int ma)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = string.Format("SELECT [dbo].[FN_KIEMTRADULIEUCD] ({0})", ma);
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
