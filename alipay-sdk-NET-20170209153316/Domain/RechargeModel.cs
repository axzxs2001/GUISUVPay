using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RechargeModel Data Structure.
    /// </summary>
    [Serializable]
    public class RechargeModel : AopObject
    {
        /// <summary>
        /// 号段
        /// </summary>
        [XmlElement("mobile_no_segment")]
        public string MobileNoSegment { get; set; }

        /// <summary>
        /// 充送
        /// </summary>
        [XmlElement("pay_send")]
        public string PaySend { get; set; }

        /// <summary>
        /// 销售产品
        /// </summary>
        [XmlArray("sale_products")]
        [XmlArrayItem("sale_product")]
        public List<SaleProduct> SaleProducts { get; set; }
    }
}
