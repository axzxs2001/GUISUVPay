using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderQuerystaffModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderQuerystaffModel : AopObject
    {
        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        public string OpePid { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，<=100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
