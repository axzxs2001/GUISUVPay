using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillPayurlGetResponse.
    /// </summary>
    public class AlipayEbppBillPayurlGetResponse : AopResponse
    {
        /// <summary>
        /// 付款页面地址
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
