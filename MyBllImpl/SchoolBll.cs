using MyIBLL;
using System;

namespace MyBllImpl
{
    internal class SchoolBll : ISchool
    {
        public IDogBll DogBll { get; set; }

        public void Fangxue()
        {
            DogBll.Back();
            Console.WriteLine("放学了");
        }
    }
}