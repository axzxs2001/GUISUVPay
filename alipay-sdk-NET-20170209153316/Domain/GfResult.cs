using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// GfResult Data Structure.
    /// </summary>
    [Serializable]
    public class GfResult : AopObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 相同身份证号个数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 用户是否存在
        /// </summary>
        [XmlElement("exist")]
        public string Exist { get; set; }

        /// <summary>
        /// 最高分
        /// </summary>
        [XmlElement("max_score")]
        public long MaxScore { get; set; }

        /// <summary>
        /// 最低分
        /// </summary>
        [XmlElement("min_score")]
        public long MinScore { get; set; }
    }
}
