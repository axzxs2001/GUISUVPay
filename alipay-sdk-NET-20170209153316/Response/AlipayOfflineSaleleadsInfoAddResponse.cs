using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsInfoAddResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsInfoAddResponse : AopResponse
    {
        /// <summary>
        /// 添加leads成功后返回
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
