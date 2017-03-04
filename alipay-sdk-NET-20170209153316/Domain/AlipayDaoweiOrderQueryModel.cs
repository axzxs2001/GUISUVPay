using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDaoweiOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiOrderQueryModel : AopObject
    {
        /// <summary>
        /// 到位业务订单号，全局唯一，由32位数字组成，用户在到位下单时系统生成并消息同步给商家，商户只能查自己同步到的订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }
    }
}
