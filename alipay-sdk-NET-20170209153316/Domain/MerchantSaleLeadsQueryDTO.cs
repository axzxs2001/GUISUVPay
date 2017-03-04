using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSaleLeadsQueryDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSaleLeadsQueryDTO : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 所在区域
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 归属人支付宝PID
        /// </summary>
        [XmlElement("assign_alipay_staff_id")]
        public string AssignAlipayStaffId { get; set; }

        /// <summary>
        /// 归属人
        /// </summary>
        [XmlElement("assign_person")]
        public string AssignPerson { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 行业分类
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 认领时间
        /// </summary>
        [XmlElement("claim_date")]
        public string ClaimDate { get; set; }

        /// <summary>
        /// 认领状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// leadsid
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户名称（公司名称）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("scale")]
        public string Scale { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public string ShopInfo { get; set; }
    }
}
