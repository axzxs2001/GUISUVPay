using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsModifyResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsModifyResponse : AopResponse
    {
        /// <summary>
        /// 被修改leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }
    }
}
