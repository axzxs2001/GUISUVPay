using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashCreateResponse : AopResponse
    {
        /// <summary>
        /// 生成的现金红包活动号
        /// </summary>
        [XmlElement("crowd_no")]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        [XmlElement("origin_crowd_no")]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动创建后的付款链接,返回的是urlencode编码后的字符串。需要进行支付宝登录，在浏览器中打开后进行付款。建议给最终给商户提供的链接为:https://auth.alipay.com/login/index.htm?goto=[pay_url],这将引导商户先登录后再进行付款。
        /// </summary>
        [XmlElement("pay_url")]
        public string PayUrl { get; set; }
    }
}
