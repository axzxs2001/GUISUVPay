using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsClaimModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsClaimModel : AopObject
    {
        /// <summary>
        /// leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 当前用户id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 异步结果通知，以及后续该流水状态变更同孩子
        /// </summary>
        [XmlElement("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
