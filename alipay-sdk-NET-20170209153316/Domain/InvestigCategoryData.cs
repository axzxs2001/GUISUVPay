using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvestigCategoryData Data Structure.
    /// </summary>
    [Serializable]
    public class InvestigCategoryData : AopObject
    {
        /// <summary>
        /// 数据项
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 实体code
        /// </summary>
        [XmlElement("entity_code")]
        public string EntityCode { get; set; }

        /// <summary>
        /// 实体名
        /// </summary>
        [XmlElement("entity_name")]
        public string EntityName { get; set; }

        /// <summary>
        /// 实体类别
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 模型结果,不同数据项,对应的模型结果对象不同,以JSON格式输出
        /// </summary>
        [XmlElement("model_result_object")]
        public string ModelResultObject { get; set; }

        /// <summary>
        /// 采集状态
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
