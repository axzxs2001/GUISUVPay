using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomtagSaveResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomtagSaveResponse : AopResponse
    {
        /// <summary>
        /// 自定义标签CODE
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
