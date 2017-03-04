using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsReleaseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsReleaseModel : AopObject
    {
        /// <summary>
        /// leads主键
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 当前操作id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 异步结果通知
        /// </summary>
        [XmlElement("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

        /// <summary>
        /// 释放原因
        /// </summary>
        [XmlElement("release_reason")]
        public string ReleaseReason { get; set; }

        /// <summary>
        /// 外部流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
