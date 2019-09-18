using System;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace ZSZ.CommonMVC
{
   public  class SendMsg
    {
        public string UserName { get; set; }
        public string AppKey { get; set; }

        public SendMsgResult SendSms(string templateId, string code, string phoneNum)
        {
            WebClient web = new WebClient();
            string url = "http://sms.rupeng.cn/SendSms.ashx?userName=" + Uri.EscapeDataString(UserName) +
                         "&appKey=" + Uri.EscapeDataString(AppKey) + "&templateId=" +
                         Uri.EscapeDataString(templateId) +
                         "&code=" + Uri.EscapeDataString(code) + "&phoneNum=" + Uri.EscapeDataString(phoneNum);
            web.Encoding = Encoding.UTF8;
            string resp = web.DownloadString(url);
            JavaScriptSerializer jss = new JavaScriptSerializer();
            SendMsgResult result = jss.Deserialize<SendMsgResult>(resp);
            return  result;
        }
    }
}
