using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.App_Code
{
   public class ClsConnections
    {
        public static SqlConnection con()
        {
            return new SqlConnection("Data Source=.;Initial Catalog=MPDb;Integrated Security=True");
        }

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=MPDb;Integrated Security=True");
        public SqlConnection ActiveCon()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }
        public void CloseCon()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }


        }
    }
}
