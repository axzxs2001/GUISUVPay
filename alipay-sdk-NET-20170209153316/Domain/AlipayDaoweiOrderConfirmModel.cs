using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDaoweiOrderConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiOrderConfirmModel : AopObject
    {
        /// <summary>
        /// 备注信息，商家确认订单时添加的备注信息，长度不超过2000个字符
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 到位业务订单号，全局唯一，由32位数字组成，用户在到位下单时系统生成并消息同步给商家，商户只能查自己同步到的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 第三方商家自己的订单号码，保证商家内部唯一，确认接单时需要设置外部订单号，长度不超过64个字符
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
