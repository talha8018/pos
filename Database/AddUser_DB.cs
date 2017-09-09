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
            int count = 0;
            string connString = ConfigurationManager.ConnectionStrings["pos"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM admin WHERE username='"+add_user.username+"'", conn);
            conn.Open();
            count = (int)cmd1.ExecuteScalar();
            conn.Close();

            if(count==0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO admin(name,username,password,phone,role,secure) VALUES('"
                + add_user.name + "','"
                + add_user.username + "','"
                + add_user.password + "','"
                + add_user.phone + "','"
                + add_user.role + "','0')", conn);


                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            return false;
            
        }

        public static void deleteUser(int id)
        {
            string connString = ConfigurationManager.ConnectionStrings["pos"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            SqlCommand cmd = new SqlCommand("DELETE FROM ADMIN WHERE ID='"+id+"'", conn);


            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
