using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace ZSZ.Common
{
    public static class Common
    {
        /// <summary>
        /// 生成16位MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Get16Md5Str(string str)
        {
            MD5CryptoServiceProvider md5Crypto = new MD5CryptoServiceProvider();
            byte[] b = Encoding.Default.GetBytes(str);
            byte[] c= md5Crypto.ComputeHash(b);
            string t2 = BitConverter.ToString(c,4,8);
            t2 = t2.Replace("-", "");
            return t2;
        }
        /// <summary>
        ///  生成32位MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Get32Md5Str(string str)
        {
            var pwd = "";
            MD5 md5 = MD5.Create();
            byte[] b = md5.ComputeHash(Encoding.Default.GetBytes(str));
            for (int i = 0; i < b.Length; i++)
            {
                pwd = pwd + b[i].ToString("x");
            }
            return pwd;
        }
        /// <summary>
        /// 生成MD5流加密
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public static string GetMd5BySteam(Stream stream)
        {
            MD5 md5 = MD5.Create();
            return md5.ComputeHash(stream).ToString();
        }
        /// <summary>
        /// 生成验证码
        /// </summary>
        /// <param name="len"></param>
        /// <returns></returns>
        public static string CreateVerifyCode(int len)
        {
            char[] data =
            {
                'a', 'c', 'd', 'e', 'f', 'g', 'h', 'j', 'k', 'm', 'n', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y',
                '2', '3', '4', '5', '6', '7', '8', '9'
            };
            StringBuilder sb = new StringBuilder();
            Random random = new Random();
            for (int i = 0; i < len; i++)
            {
                int index = random.Next(data.Length);
                char ch = data[index];
                sb.Append(ch);
            }
            return sb.ToString();
        }
        /// <summary>
        /// 通过QQ邮箱发送邮箱
        /// </summary>
        /// <param name="inMail"></param>
        /// <param name="body"></param>
        /// <param name="formMail"></param>
        /// <param name="title"></param>
        public static void SendEmail(string inMail,string body,string formMail,string title)
        {
            using (MailMessage mailMessage = new MailMessage())
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.qq.com"))
                {
                    mailMessage.To.Add(inMail);
                    mailMessage.Body = body;
                    mailMessage.From=new MailAddress(formMail);
                    mailMessage.Subject = title;
                    smtpClient.Credentials = new NetworkCredential("704279465@qq.com", "nnojulkqjcbobfha");
                    smtpClient.Send(mailMessage);
                }
            }
        }
    }
}
