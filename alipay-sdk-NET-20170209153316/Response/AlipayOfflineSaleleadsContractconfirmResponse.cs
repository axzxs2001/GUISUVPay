using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsContractconfirmResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsContractconfirmResponse : AopResponse
    {
        /// <summary>
        /// 当面付审核状态
        /// </summary>
        [XmlElement("ff_audit_status")]
        public string FfAuditStatus { get; set; }

        /// <summary>
        /// 当面付审核通过时间
        /// </summary>
        [XmlElement("ff_audit_time")]
        public string FfAuditTime { get; set; }

        /// <summary>
        /// 当面付生效时间
        /// </summary>
        [XmlElement("ff_online")]
        public string FfOnline { get; set; }

        /// <summary>
        /// 是否开店
        /// </summary>
        [XmlElement("is_open_shop")]
        public string IsOpenShop { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("is_sign")]
        public string IsSign { get; set; }

        /// <summary>
        /// leads id
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }
    }
}
