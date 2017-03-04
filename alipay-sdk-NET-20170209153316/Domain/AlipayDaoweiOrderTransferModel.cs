using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDaoweiOrderTransferModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiOrderTransferModel : AopObject
    {
        /// <summary>
        /// 备注信息，第三方商家在推进订单状态的时候的填写的备注信息，用于告知到位或者服务的购买者的相关信息，不超过500字符
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单动作，需要推进的订单状态，枚举值，目前支持的订单状态是PROVIDER_CONFIRMED (服务者完成服务)。
        /// </summary>
        [XmlElement("order_action")]
        public string OrderAction { get; set; }

        /// <summary>
        /// 到位业务订单号，全局唯一，由32位数字组成，用户在到位下单时系统生成并消息同步给商家，商户只能查自己同步到的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
