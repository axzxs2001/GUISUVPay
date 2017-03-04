using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSmartactivityForecastModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataSmartactivityForecastModel : AopObject
    {
        /// <summary>
        /// 活动配置CODE
        /// </summary>
        [XmlElement("config_code")]
        public string ConfigCode { get; set; }

        /// <summary>
        /// 诊断结果CODE，目前有如下三个值  TRADE_RATE 流失会员占比高  USER_COUNT 会员数量少  REPAY_RATE 复购率低
        /// </summary>
        [XmlElement("diagnose_code")]
        public string DiagnoseCode { get; set; }

        /// <summary>
        /// 可选参数有如下几个：  worth_value:奖品面额 单位：分  min_consume:门槛 单位：分  voucher_valid_days:券有效期天数  activity_valid_days:活动有效期天数  min_cost:领券门槛 单位：分
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
