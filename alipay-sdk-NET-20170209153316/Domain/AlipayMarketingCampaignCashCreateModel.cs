using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignCashCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignCashCreateModel : AopObject
    {
        /// <summary>
        /// 红包名称,商户在查询列表、详情看到的名字,同时也会显示在商户付款页面。
        /// </summary>
        [XmlElement("coupon_name")]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动结束时间,必须大于活动开始时间, 基本格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商户打款后的跳转链接，从支付宝收银台打款成功后的跳转链接。不填时，打款后停留在支付宝支付成功页。商户实际跳转会自动添加crowdNo作为跳转参数。示例: http://www.koubei.com?crowdNo=XXX
        /// </summary>
        [XmlElement("merchant_link")]
        public string MerchantLink { get; set; }

        /// <summary>
        /// 活动文案,用户在账单、红包中看到的账单描述、红包描述
        /// </summary>
        [XmlElement("prize_msg")]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式, fixed为固定金额,random为随机金额。选择随机金额时，单个红包的金额在平均金额的0.5~1.5倍之间浮动。
        /// </summary>
        [XmlElement("prize_type")]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动开始时间,必须大于活动创建的时间.   (1) 填固定时间:2016-08-10 22:28:30, 基本格式:yyyy-MM-dd HH:mm:ss  (2) 填字符串NowTime
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动发放的现金总金额,最小金额1.00元,最大金额10000000.00元。每个红包的最大金额不允许超过200元,最小金额不得低于0.20元。 实际的金额限制可能会根据业务进行动态调整。
        /// </summary>
        [XmlElement("total_money")]
        public string TotalMoney { get; set; }

        /// <summary>
        /// 红包发放个数，不同的发奖类型含义不同：  (1) 固定金额：活动总共发放的现金红包个数,最小1个,最大10000000个。 实际的个数限制可能会根据业务进行动态调整。  (2) 随机金额：用于计算每个随机红包的平均值，但最终发放个数不一定是total_num，可能大于也可能小于。
        /// </summary>
        [XmlElement("total_num")]
        public string TotalNum { get; set; }
    }
}
