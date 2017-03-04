using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiMarketingDataCustomtagBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingDataCustomtagBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 自定义标签详情信息
        /// </summary>
        [XmlArray("custom_tag_list")]
        [XmlArrayItem("custom_tag_info")]
        public List<CustomTagInfo> CustomTagList { get; set; }
    }
}
