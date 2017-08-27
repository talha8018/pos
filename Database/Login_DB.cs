using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Login_DB
    {
        public static int authentication(Login_Model login)
        {
            int count = 0;
            string connString = ConfigurationManager.ConnectionStrings["pos"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand("sp_auth", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = login.username;
            cmd.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = login.password;

            conn.Open();
            count = (int)cmd.ExecuteScalar();
            conn.Close();
            
            return count;
        }
    }
}
