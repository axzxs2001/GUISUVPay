using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsClaimstatusResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsClaimstatusResponse : AopResponse
    {
        /// <summary>
        /// success(成功);fail(失败)
        /// </summary>
        [XmlElement("res_msg")]
        public string ResMsg { get; set; }
    }
}
