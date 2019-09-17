using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIBLL
{

    public interface IUserBll
    {
        void AddNew(string username, string password);

        bool Check(string username);
    }
}
