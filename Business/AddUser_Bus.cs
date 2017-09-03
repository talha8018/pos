using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Database;


namespace Business
{
    public class AddUser_Bus
    {
        public static bool addUser(AddUser_Model add_user)
        {
            bool user_added = AddUser_DB.isUserAdded(add_user); ;
            return user_added;
        }
    }
}
