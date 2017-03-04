using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketShopAssignstaffModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketShopAssignstaffModel : AopObject
    {
        /// <summary>
        /// 员工支付宝卡号ID
        /// </summary>
        [XmlElement("allocated_staff_id")]
        public string AllocatedStaffId { get; set; }

        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        public string OpePid { get; set; }

        /// <summary>
        /// 请求流水id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 门店id,可以多个，“，”分隔
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
