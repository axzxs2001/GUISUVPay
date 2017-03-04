using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GraphNegInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class GraphNegInfoModel : AopObject
    {
        /// <summary>
        /// 案号
        /// </summary>
        [XmlElement("case_code")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 法律生效文书确定的义务
        /// </summary>
        [XmlElement("duty")]
        public string Duty { get; set; }

        /// <summary>
        /// 失信被执行人姓名/机构名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 被执行人的履行情况
        /// </summary>
        [XmlElement("performance")]
        public string Performance { get; set; }

        /// <summary>
        /// 立案时间
        /// </summary>
        [XmlElement("reg_date")]
        public string RegDate { get; set; }
    }
}
