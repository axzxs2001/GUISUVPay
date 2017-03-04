using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsMerchantEquipmentQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsMerchantEquipmentQueryModel : AopObject
    {
        /// <summary>
        /// 商户PID（merchant_pid和shop_id必填其一）
        /// </summary>
        [XmlElement("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("ope_pid")]
        public string OpePid { get; set; }

        /// <summary>
        /// 请求流水id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 商户下的门店ID（merchant_pid和shop_id必填其一）
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
