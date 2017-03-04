using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsQuerybyidsResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsQuerybyidsResponse : AopResponse
    {
        /// <summary>
        /// 查询Leads信息对象集合
        /// </summary>
        [XmlArray("merchantsaleleadsquerylist")]
        [XmlArrayItem("merchant_sale_leads_query_d_t_o")]
        public List<MerchantSaleLeadsQueryDTO> Merchantsaleleadsquerylist { get; set; }
    }
}
