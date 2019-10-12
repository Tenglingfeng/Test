using MyIBLL;
using System;

namespace MyBllImpl
{
    public class UserBll : IUserBll
    {
        public void AddNew(string username, string password)
        {
            Console.WriteLine("username" + username);
        }

        public bool Check(string username)
        {
            Console.WriteLine("usernmae" + username);
            return true;
        }
    }
}