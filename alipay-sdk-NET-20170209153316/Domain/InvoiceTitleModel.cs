using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceTitleModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceTitleModel : AopObject
    {
        /// <summary>
        /// 是否默认  可选值：  false：非默认  true：默认抬头
        /// </summary>
        [XmlElement("is_default")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        [XmlElement("open_bank_account")]
        public string OpenBankAccount { get; set; }

        /// <summary>
        /// 开户行
        /// </summary>
        [XmlElement("open_bank_name")]
        public string OpenBankName { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// </summary>
        [XmlElement("tax_register_no")]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 发票抬头名称
        /// </summary>
        [XmlElement("title_name")]
        public string TitleName { get; set; }

        /// <summary>
        /// 发票类型  可选值：  PERSONAL（个人抬头）  CORPORATION（公司抬头）
        /// </summary>
        [XmlElement("title_type")]
        public string TitleType { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("user_address")]
        public string UserAddress { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        [XmlElement("user_email")]
        public string UserEmail { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户手机号
        /// </summary>
        [XmlElement("user_mobile")]
        public string UserMobile { get; set; }
    }
}
