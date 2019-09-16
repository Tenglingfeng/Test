using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using ZSZ.Common;

namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Common.GetImagePro(@"C:\Users\Administrator\Desktop\5d1c74ae217a6.jpg", @"D:\Project\ZSZ\ZSZ.Common\image", "测试缩略");
            // Common.GetWatermarkImage(@"D:\Project\ZSZ\ZSZ.Common\image\u=3360416245,4182718311&fm=26&gp=0.jpg",100, @"D:\Project\ZSZ\ZSZ.Common\image\5d1c74ae217a6.jpg",@"D:\Project\ZSZ\ZSZ.Common\image", "测试水印");
            log4net.Config.XmlConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(Program));
            log.Debug("debug2");
            log.Warn("warn////////////");
            log.Error("error----------");
            //var code = Common.CreateVerifyCode(5);
            //Common.GetCodeImage(code,30,80,10,5,@"D:\Project\ZSZ\ZSZ.Common\image", "测试验证码图片");
            Console.WriteLine("OK");
           // Console.ReadKey();
        }
    }
}
