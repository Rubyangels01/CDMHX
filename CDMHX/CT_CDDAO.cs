using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class CT_CDDAO
    {
        DataTable listCT_CD;
        DataConnection dc;
        public CT_CDDAO()
        {
            dc = new DataConnection();
        }
        public DataTable createTB()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TenCV");
            dt.Columns.Add("MaNhom");
            dt.Columns.Add("Buoi");
            dt.Columns.Add("Ngay");
            dt.Columns.Add("TenAp");
            return dt;
        }
        public DataTable GetAllCongViec(int maCD)
        {

            listCT_CD = createTB();

            SqlCommand command = new SqlCommand();
            command.Connection = dc.getConnec();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_DSCV_CD";

            command.Parameters.Add("@MaNam", SqlDbType.Int).Value = maCD;
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
               
                // Xử lý dữ liệu lấy được từ công việc

                int MaNhom = (int)reader["MaNhom"];
                string TenCV = reader["TenCV"].ToString();
               string buoi = reader["Buoi"].ToString();
               DateTime Ngay = (DateTime)reader["Ngay"];
                string ap = reader["TenAp"].ToString();



                listCT_CD.Rows.Add(TenCV,MaNhom, buoi, Ngay, ap);

            }

            reader.Close();
            dc.getConnec().Close();
            return listCT_CD;
        }

    }
}
