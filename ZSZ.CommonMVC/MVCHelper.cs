using System.Text;
using System.Web.ModelBinding;

namespace ZSZ.CommonMVC
{
    /// <summary>
    /// 表单校验
    /// </summary>
    public static class MvcHelper
    {
        public static string GetValidMsg(ModelStateDictionary modelState)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var key in modelState.Keys)
            {
                if (modelState[key].Errors.Count<=0)
                {
                    continue;
                }
                sb.Append("属性[").Append(key).Append("]错误:");
                foreach (var modelError in modelState[key].Errors)
                {
                    sb.AppendLine(modelError.ErrorMessage);
                }
            }
            return sb.ToString();
        }
    }
}
