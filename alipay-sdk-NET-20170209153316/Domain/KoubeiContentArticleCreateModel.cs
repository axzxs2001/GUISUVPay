using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiContentArticleCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiContentArticleCreateModel : AopObject
    {
        /// <summary>
        /// 作者简介
        /// </summary>
        [XmlElement("author_intro")]
        public string AuthorIntro { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [XmlElement("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// 封面
        /// </summary>
        [XmlElement("cover")]
        public ArticlePicture Cover { get; set; }

        /// <summary>
        /// 文章简介长度不能大于500，已描述为准
        /// </summary>
        [XmlElement("introduction")]
        public string Introduction { get; set; }

        /// <summary>
        /// 正文段落，所有段落总字数不能少于300字，整个正文必须至少一张图片
        /// </summary>
        [XmlArray("paragraph_list")]
        [XmlArrayItem("article_paragraph")]
        public List<ArticleParagraph> ParagraphList { get; set; }

        /// <summary>
        /// 内容提供的机构
        /// </summary>
        [XmlElement("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 店铺图片适用的门店列表，目前仅支持1个店铺，可通过接口alipay.offline.market.shop.summary.batchquery来获取商户下的门店列表，请求参数query_type需要设置为CONTENT_RELATION
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 店铺名
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 文章标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
