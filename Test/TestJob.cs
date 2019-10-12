using Quartz;
using System;

namespace Test
{
    internal class TestJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            Console.WriteLine("定时任务执行了!!!");
        }
    }
}