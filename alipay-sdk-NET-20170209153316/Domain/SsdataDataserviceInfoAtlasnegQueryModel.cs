using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SsdataDataserviceInfoAtlasnegQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceInfoAtlasnegQueryModel : AopObject
    {
        /// <summary>
        /// 填写法人,任职,投资,股权，如"法人,投资"就是以给定节点查找这两种关联关系的节点，以英文逗号作为分隔符
        /// </summary>
        [XmlElement("edges")]
        public string Edges { get; set; }

        /// <summary>
        /// 企业中文名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 从给定的节点向外扩展的企业层数，比如，2，就代表从给定的企业名称找2度关联的企业
        /// </summary>
        [XmlElement("step")]
        public string Step { get; set; }
    }
}
