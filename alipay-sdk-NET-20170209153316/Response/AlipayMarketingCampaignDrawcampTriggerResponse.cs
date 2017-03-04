using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampTriggerResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampTriggerResponse : AopResponse
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 活动流水id
        /// </summary>
        [XmlElement("camp_log_id")]
        public string CampLogId { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [XmlElement("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 奖品唯一标识
        /// </summary>
        [XmlElement("prize_flag")]
        public string PrizeFlag { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [XmlElement("prize_id")]
        public string PrizeId { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [XmlElement("prize_name")]
        public string PrizeName { get; set; }

        /// <summary>
        /// 是否中奖结果状态，如果为true时返回的结果中的其他字段非空，否则返回的其他字段为空
        /// </summary>
        [XmlElement("trigger_result")]
        public bool TriggerResult { get; set; }
    }
}
