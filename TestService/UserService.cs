using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using TestIService;

namespace TestService
{
    public class UserService:IUserService
    {
        public bool CheckLogin(string username, string pwd)
        {
            return true;
        }

        public bool CheckUsernameExt(string username)
        {
            return false;
        }
    }
}
