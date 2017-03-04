using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomtagDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomtagDeleteModel : AopObject
    {
        /// <summary>
        /// 标签code，创建自定义标签时返回的
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
