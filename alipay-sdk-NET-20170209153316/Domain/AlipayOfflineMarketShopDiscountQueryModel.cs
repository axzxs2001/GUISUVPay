using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopDiscountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopDiscountQueryModel : AopObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
