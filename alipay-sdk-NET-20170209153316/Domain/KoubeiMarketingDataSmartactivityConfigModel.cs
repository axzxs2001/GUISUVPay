using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataSmartactivityConfigModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataSmartactivityConfigModel : AopObject
    {
        /// <summary>
        /// 诊断结果CODE，目前有如下三个值  TRADE_RATE 流失会员占比高  USER_COUNT 会员数量少  REPAY_RATE 复购率低
        /// </summary>
        [XmlElement("diagnose_code")]
        public string DiagnoseCode { get; set; }
    }
}
