using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AliTrustRiskUser Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustRiskUser : AopObject
    {
        /// <summary>
        /// 如果在风险名单中,记录被列入风险名单的日期;否则为空
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 如果在风险名单中,记录被列入风险名单的原因;否则为空
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 是否在风险名单库中的标识
        /// </summary>
        [XmlElement("risk")]
        public bool Risk { get; set; }

        /// <summary>
        /// 值始终为"阿里小贷"
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }
    }
}
