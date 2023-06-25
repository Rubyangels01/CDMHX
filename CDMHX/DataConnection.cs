using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDMHX
{
    class DataConnection
    {
        string strconnec;
        SqlConnection connection;

        public DataConnection()
        {
            strconnec = @"Data Source=ADMIN-PC;Initial Catalog=MUAHEXANH;Persist Security Info=True;User ID=me;Password=123";
            connection = new SqlConnection(strconnec);
        }

        public SqlConnection getConnec()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

       
    }

}
