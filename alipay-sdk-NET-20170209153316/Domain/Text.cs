using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// Text Data Structure.
    /// </summary>
    [Serializable]
    public class Text : AopObject
    {
        /// <summary>
        /// 你好!
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
