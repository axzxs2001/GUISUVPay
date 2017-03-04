using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMenuCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMenuCreateModel : AopObject
    {
        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public Picture Cover { get; set; }

        /// <summary>
        /// 菜品ids列表
        /// </summary>
        [XmlArray("dishes")]
        [XmlArrayItem("string")]
        public List<string> Dishes { get; set; }

        /// <summary>
        /// 店铺图片适用的门店列表，最多支持500，可通过接口alipay.offline.market.shop.summary.batchquery来获取商户下的门店列表，请求参数query_type需要设置为CONTENT_RELATION
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 菜单标题名称，最多12个字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
