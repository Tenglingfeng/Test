using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIBLL;

namespace MyBllImpl
{
    public class UserBll:IUserBll
    {
        public void AddNew(string username, string password)
        {
            Console.WriteLine("username"+username);
        }

        public bool Check(string username)
        {
            Console.WriteLine("usernmae"+username);
            return true;
        }
    }
}
