using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using log4net;
using MyIBLL;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using ZSZ.Common;
using IContainer = Autofac.IContainer;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {

           
            ContainerBuilder builder = new ContainerBuilder();
            Assembly asm = Assembly.Load("MyBllImpl");
            builder.RegisterAssemblyTypes(asm).AsImplementedInterfaces().PropertiesAutowired();
            IContainer container = builder.Build();
            var school = container.Resolve<ISchool>();
            school.Fangxue();
            Console.WriteLine("OK");
            Console.ReadKey();
            //var blls = container.Resolve<IEnumerable<IUserBll>>();
            //foreach (var bll in blls)
            //{
            //    Console.WriteLine(bll.GetType());
            //    bll.AddNew("aa", "23");
            //}

            // Common.GetImagePro(@"C:\Users\Administrator\Desktop\5d1c74ae217a6.jpg", @"D:\Project\ZSZ\ZSZ.Common\image", "测试缩略");
            // Common.GetWatermarkImage(@"D:\Project\ZSZ\ZSZ.Common\image\u=3360416245,4182718311&fm=26&gp=0.jpg",100, @"D:\Project\ZSZ\ZSZ.Common\image\5d1c74ae217a6.jpg",@"D:\Project\ZSZ\ZSZ.Common\image", "测试水印");
            //log4net.Config.XmlConfigurator.Configure();
            //ILog log = LogManager.GetLogger(typeof(Program));
            //log.Debug("debug2");
            //log.Warn("warn////////////");
            //log.Error("error----------");
            //var code = Common.CreateVerifyCode(5);
            //Common.GetCodeImage(code,30,80,10,5,@"D:\Project\ZSZ\ZSZ.Common\image", "测试验证码图片");
            //IScheduler scheduler = new StdSchedulerFactory().GetScheduler();
            //JobDetailImpl jobDetailImpl = new JobDetailImpl("jobTest", typeof(TestJob));
            //var trigger = CalendarIntervalScheduleBuilder.Create().WithInterval(3,IntervalUnit.Second).Build();
            ////IMutableTrigger trigger = CronScheduleBuilder.DailyAtHourAndMinute(21, 44).Build();
            //trigger.Key = new TriggerKey("triggerTest");
            //scheduler.ScheduleJob(jobDetailImpl, trigger);
            //scheduler.Start();
        }
    }
}
