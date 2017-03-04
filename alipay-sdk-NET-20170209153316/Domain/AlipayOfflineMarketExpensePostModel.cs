using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketExpensePostModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketExpensePostModel : AopObject
    {
        /// <summary>
        /// 操作方法
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 操作请求参数，JSON格式
        /// </summary>
        [XmlElement("request")]
        public string Request { get; set; }
    }
}
