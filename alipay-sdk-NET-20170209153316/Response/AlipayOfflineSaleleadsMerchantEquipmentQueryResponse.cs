using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineSaleleadsMerchantEquipmentQueryResponse.
    /// </summary>
    public class AlipayOfflineSaleleadsMerchantEquipmentQueryResponse : AopResponse
    {
        /// <summary>
        /// 商户名称
        /// </summary>
        [XmlElement("merchant_name")]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 门店机具绑定信息
        /// </summary>
        [XmlArray("shopinfos")]
        [XmlArrayItem("shop_equipment_bind_info")]
        public List<ShopEquipmentBindInfo> Shopinfos { get; set; }
    }
}
