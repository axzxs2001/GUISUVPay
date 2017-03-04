using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineProviderQuerystaffResponse.
    /// </summary>
    public class AlipayOfflineProviderQuerystaffResponse : AopResponse
    {
        /// <summary>
        /// 当前分页数
        /// </summary>
        [XmlElement("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页分页条数
        /// </summary>
        [XmlElement("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 员工信息列表
        /// </summary>
        [XmlArray("query_result")]
        [XmlArrayItem("staff_d_t_o")]
        public List<StaffDTO> QueryResult { get; set; }

        /// <summary>
        /// 总员工数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 总分页数
        /// </summary>
        [XmlElement("total_pages")]
        public long TotalPages { get; set; }
    }
}
