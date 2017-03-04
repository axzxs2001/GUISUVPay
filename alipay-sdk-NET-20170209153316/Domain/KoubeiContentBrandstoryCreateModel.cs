using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiContentBrandstoryCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentBrandstoryCreateModel : AopObject
    {
        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public Picture Cover { get; set; }

        /// <summary>
        /// 正文必填  段落不能为空, 最多5段   每段最多3张图片 每个段落文字最多500字
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("paragraph")]
        public List<Paragraph> ParagraphList { get; set; }

        /// <summary>
        /// 店铺图片适用的门店列表，最多支持500，可通过接口alipay.offline.market.shop.summary.batchquery来获取商户下的门店列表，请求参数query_type需要设置为CONTENT_RELATION
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 标题，最多25个字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 视频
        /// </summary>
        [XmlElement("video")]
        public Video Video { get; set; }
    }
}
