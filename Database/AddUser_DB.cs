using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class AddUser_DB
    {
        public static bool isUserAdded(AddUser_Model add_user)
        {
            string connString = ConfigurationManager.ConnectionStrings["pos"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand("INSERT INTO admin(name,username,password,phone,role) VALUES('"
                +add_user.name+"','"
                +add_user.username+"','"
                +add_user.password+"','"
                +add_user.phone+"','"
                +add_user.role+"')",conn);
           

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            return true;
        }
    }
}
