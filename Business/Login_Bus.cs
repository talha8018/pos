using Database;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Login_Bus
    {
        public static int authentication(Login_Model login)
        {
            int is_auth = Login_DB.authentication(login);
            return is_auth;
        }
    }
}
