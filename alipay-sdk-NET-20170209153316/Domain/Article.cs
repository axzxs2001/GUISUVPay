using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Article Data Structure.
    /// </summary>
    [Serializable]
    public class Article : AopObject
    {
        /// <summary>
        /// 链接文字
        /// </summary>
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 图文消息内容
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接，对于多条图文消息的第一条消息，该字段不能为空
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 图文消息标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 点击图文消息跳转的链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
