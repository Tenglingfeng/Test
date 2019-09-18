using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1
{
    public class TrimToDbcModelBinder:DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            object value = base.BindModel(controllerContext, bindingContext);
            if (value is  string)
            {
                string strValue = (string) value;
                string value2 = ToDbc(strValue);
                return value2;
            }
            else
            {
                return value;
            }
        }
        /// <summary>
        /// 全角转半角字符的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角空格为12288 半角空格为32  其他字符半角(33-126) 全角(65218-65374)</returns>
        private static string ToDbc(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                {
                    c[i] = (char)(c[i] - 65248);
                }
            }
            return new string(c);
        }
        //然后在Global 中:
        //ModelBinders.Binders.Add(typeof(string),new TrimToDBCModelBinder() )
    }
}