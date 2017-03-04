using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantSaleLeadsQueryBypageDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantSaleLeadsQueryBypageDTO : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 认领Leads的服务商支付宝卡号
        /// </summary>
        [XmlElement("agent_alipay_card_no")]
        public string AgentAlipayCardNo { get; set; }

        /// <summary>
        /// 商户支付宝卡号
        /// </summary>
        [XmlElement("alipay_card_no")]
        public string AlipayCardNo { get; set; }

        /// <summary>
        /// 所属区域
        /// </summary>
        [XmlElement("area")]
        public string Area { get; set; }

        /// <summary>
        /// 所属支付宝小二
        /// </summary>
        [XmlElement("assign_alipay_staff_id")]
        public string AssignAlipayStaffId { get; set; }

        /// <summary>
        /// 分配主体----服务商小二
        /// </summary>
        [XmlElement("assign_principal_id")]
        public string AssignPrincipalId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand")]
        public string Brand { get; set; }

        /// <summary>
        /// 品牌编码
        /// </summary>
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 分类说明
        /// </summary>
        [XmlElement("category")]
        public string Category { get; set; }

        /// <summary>
        /// 商户认领状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当面付审核状态
        /// </summary>
        [XmlElement("ff_audit_status")]
        public string FfAuditStatus { get; set; }

        /// <summary>
        /// 当面付生效时间
        /// </summary>
        [XmlElement("ff_online")]
        public string FfOnline { get; set; }

        /// <summary>
        /// leads创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 是否开店
        /// </summary>
        [XmlElement("is_open_shop")]
        public string IsOpenShop { get; set; }

        /// <summary>
        /// leadsId
        /// </summary>
        [XmlElement("leands_id")]
        public string LeandsId { get; set; }

        /// <summary>
        /// leads名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 其它联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("scale")]
        public string Scale { get; set; }

        /// <summary>
        /// 商户外部标识，来源于支付宝体系外
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 商户外部标识类型，来源于支付宝体系外
        /// </summary>
        [XmlElement("seller_id_type")]
        public string SellerIdType { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [XmlElement("shop_info")]
        public string ShopInfo { get; set; }

        /// <summary>
        /// 当leads签约的pid是非云纵pid，且leads是被签约的leads信息说明
        /// </summary>
        [XmlElement("show_info")]
        public string ShowInfo { get; set; }

        /// <summary>
        /// 签约审核状态
        /// </summary>
        [XmlElement("sign_audit_status")]
        public string SignAuditStatus { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }
    }
}
