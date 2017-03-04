using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillBatchPayurlGetResponse.
    /// </summary>
    public class AlipayEbppBillBatchPayurlGetResponse : AopResponse
    {
        /// <summary>
        /// 收银台链接
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
