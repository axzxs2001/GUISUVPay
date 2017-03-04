using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopPicCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopPicCreateModel : AopObject
    {
        /// <summary>
        /// 环境图名称，不能超过12个字，同一个商户下环境图的名称不允许重复
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 图片列表，这里的图片类型仅支持ENVIRONMENT，目前只允许传一张图片
        /// </summary>
        [XmlArray("pictures")]
        [XmlArrayItem("content_picture")]
        public List<ContentPicture> Pictures { get; set; }

        /// <summary>
        /// 店铺图片适用的门店列表，最多支持500，可通过接口alipay.offline.market.shop.summary.batchquery来获取商户下的门店列表，请求参数query_type需要设置为CONTENT_RELATION
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }
    }
}
