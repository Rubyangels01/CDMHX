using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace CDMHX
{
    static class Program
    {
        public static String connPublisherString = @"Data Source=ADMIN-PC;Initial Catalog=MUAHEXANH;Persist Security Info=True;User ID=me;Password=123";
        public static SqlConnection conn = new SqlConnection();
        public static String connString = null;
        public static String login = "";
        public static String username = "";
        public static String password = "";
        public static String name = "";
        public static String group = "";

        //Tài khoản đăng nhập
        public static String loginLogin = "";
        public static String loginPassword = "";
        public static DataConnection dc = new DataConnection();



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            dc.getConnec();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DANGNHAP());
        }



        public static int ConnectSql()
        {
            if (conn != null || Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();

            }
            try
            {
                Program.conn.ConnectionString = "Data Source = ADMIN-PC; Initial Catalog = MUAHEXANH; Integrated Security = True";
                Program.conn.Open();
                SqlDataReader myReader = Program.ExecSqlDataReader("SELECT * FROM sys.sql_logins WHERE name = '" + Program.login + "'");
                if (myReader.Read())
                {
                    Program.conn.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại trong server chỉ định");
                    Program.conn.Close();
                    myReader.Close();
                    return 0;
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối server");
                return 0;
            }
            try
            {
                connString = "Data Source= ADMIN-PC"
                    + ";Initial Catalog= MUAHEXANH"
                    + ";User ID=" + Program.login
                    + ";Password=" + Program.password;
                Program.conn.ConnectionString = connString;
                Program.conn.Open();
                return 1;
            }
            catch (SqlException ex)
            {
                connString = null;
                MessageBox.Show("Mật khẩu login không chính xác");
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String query)
        {
            SqlDataReader myReader;
            SqlCommand cmd = new SqlCommand(query, Program.conn);
            cmd.CommandType = System.Data.CommandType.Text;
            if (Program.conn.State == System.Data.ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = cmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static List<string> LayMaCD()
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
        public static int ConvertStringToInt(string input)
        {
            int result;
            bool success = int.TryParse(input, out result);

            return result;
        }

        /*
        Hàm ExecSqlDataTable này giúp thực thi truy vấn SQL và
        trả về dữ liệu dưới dạng DataTable, giúp bạn có thể sử dụng và xử lý dữ liệu thuận tiện hơn.
        *//*
        public static DataTable ExecSqlDataTable(String query)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(query, Program.conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        //INSERT, UPDATE, DELETE
        public static int ExecSqlNonQuery(String cmdString)
        {
            SqlCommand cmd = new SqlCommand(cmdString, Program.conn);
            cmd.CommandType = CommandType.Text;

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                Program.conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; 
            }
        }*/
    }
}
