using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDaoweiServicePriceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiServicePriceModifyModel : AopObject
    {
        /// <summary>
        /// 外部服务id,商家自己维护的唯一标识,用于确定商家的某个服务.仅支持数字,字母和下划线
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 价格维度类型，可选值:string；json。string表示unit_price的类型是一维价格，如果是json表示多维价格
        /// </summary>
        [XmlElement("price_dim_type")]
        public string PriceDimType { get; set; }

        /// <summary>
        /// 单价，单位为元，根据price_dim_type的值决定如果是一维价格直接使用字符串，比如："30.5"，如果是多维，比如同一个属性不同地区价格不同的情况，比如  {    "-1": "30", //表示默认价   "110100": "60"  }  "110100"为北京城市码，参考高德标准，该配置表示北京地区价格60元，其他地区价格30元
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
