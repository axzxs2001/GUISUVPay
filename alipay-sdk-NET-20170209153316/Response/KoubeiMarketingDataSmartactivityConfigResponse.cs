using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataSmartactivityConfigResponse.
    /// </summary>
    public class KoubeiMarketingDataSmartactivityConfigResponse : AopResponse
    {
        /// <summary>
        /// 活动类型  CONSUME_SEND 消费送  DIRECT_SEND 直发奖  GUESS_SEND 口令送
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 活动有效天数
        /// </summary>
        [XmlElement("activity_valid_days")]
        public string ActivityValidDays { get; set; }

        /// <summary>
        /// 活动配置CODE
        /// </summary>
        [XmlElement("config_code")]
        public string ConfigCode { get; set; }

        /// <summary>
        /// 活动人群对象，包含针对N天未消费的用户/所有用户
        /// </summary>
        [XmlElement("crowd_group")]
        public string CrowdGroup { get; set; }

        /// <summary>
        /// 奖品面额门槛（阶梯状），消费满不同的金额可以使用不同的券,单位：分
        /// </summary>
        [XmlElement("min_consume")]
        public string MinConsume { get; set; }

        /// <summary>
        /// 领券门槛（阶梯状），消费满不同的金额发不同金额的券券  活动类型为消费送且不是消费送礼包时设置  多营销工具之间不允许设置重复值  单位：分
        /// </summary>
        [XmlElement("min_cost")]
        public string MinCost { get; set; }

        /// <summary>
        /// 目前支持以下类型：  EXCHANGE：兑换券  MONEY：代金券  REDUCETO：减至券  RATE：折扣券
        /// </summary>
        [XmlElement("voucher_type")]
        public string VoucherType { get; set; }

        /// <summary>
        /// 券有效天数
        /// </summary>
        [XmlElement("voucher_valid_days")]
        public string VoucherValidDays { get; set; }

        /// <summary>
        /// 券面额，折扣券为折扣比例、立减为金额 单位：分
        /// </summary>
        [XmlElement("worth_value")]
        public string WorthValue { get; set; }
    }
}
