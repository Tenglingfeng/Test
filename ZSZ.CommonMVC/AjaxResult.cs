namespace ZSZ.CommonMVC
{
    /// <summary>
    /// 所有的ajax都要返回这个类型的对象
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 执行的结果
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 执行返回的数据
        /// </summary>
        public object Data { get; set; }
    }
}