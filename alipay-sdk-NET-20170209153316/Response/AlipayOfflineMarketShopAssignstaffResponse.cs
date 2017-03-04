using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopAssignstaffResponse.
    /// </summary>
    public class AlipayOfflineMarketShopAssignstaffResponse : AopResponse
    {
        /// <summary>
        /// 如果失败，存放原因
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 分配失败的门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
