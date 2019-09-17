using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyIBLL;

namespace MyBllImpl
{
    class SchoolBll : ISchool
    {
        public IDogBll DogBll{ get; set; }
        public void Fangxue()
        {

            DogBll.Back();
            Console.WriteLine("放学了");
        }
    }
}
