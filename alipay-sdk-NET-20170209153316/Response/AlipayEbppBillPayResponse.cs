using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppBillPayResponse.
    /// </summary>
    public class AlipayEbppBillPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        [XmlElement("order_type")]
        public string OrderType { get; set; }
    }
}
