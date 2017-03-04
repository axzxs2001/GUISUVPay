using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsInfoQuerybypageResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsInfoQuerybypageResponse : AopResponse
    {
        /// <summary>
        /// 服务商按照条件分页查询leads信息返回信息
        /// </summary>
        [XmlArray("merchantsaleleadsquerybypagelist")]
        [XmlArrayItem("merchant_sale_leads_query_bypage_d_t_o")]
        public List<MerchantSaleLeadsQueryBypageDTO> Merchantsaleleadsquerybypagelist { get; set; }
    }
}
