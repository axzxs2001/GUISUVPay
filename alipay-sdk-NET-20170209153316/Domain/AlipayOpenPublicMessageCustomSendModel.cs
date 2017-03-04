using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageCustomSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMessageCustomSendModel : AopObject
    {
        /// <summary>
        /// 图文消息，当msg_type为image-text时，必须存在相对应的值
        /// </summary>
        [XmlArray("articles")]
        [XmlArrayItem("article")]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 消息类型，text：文本消息，image-text：图文消息
        /// </summary>
        [XmlElement("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 当msg_type为text时，必须设置相对应的值
        /// </summary>
        [XmlElement("text")]
        public Text Text { get; set; }

        /// <summary>
        /// 消息接收用户的userid
        /// </summary>
        [XmlElement("to_user_id")]
        public string ToUserId { get; set; }
    }
}
