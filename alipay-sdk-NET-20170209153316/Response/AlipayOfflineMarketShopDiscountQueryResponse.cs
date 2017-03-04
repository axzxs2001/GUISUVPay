using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopDiscountQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopDiscountQueryResponse : AopResponse
    {
        /// <summary>
        /// 优惠信息列表，最大20条，按生效时间排序
        /// </summary>
        [XmlArray("discount_list")]
        [XmlArrayItem("shop_discount_info")]
        public List<ShopDiscountInfo> DiscountList { get; set; }

        /// <summary>
        /// 商品列表，最大20条，按申领数量排序
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("shop_discount_info")]
        public List<ShopDiscountInfo> ItemList { get; set; }
    }
}
