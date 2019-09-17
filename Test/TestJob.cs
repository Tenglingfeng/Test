using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;

namespace Test
{
    class TestJob:IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("定时任务执行了!!!");
        }
    }
}
