using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BankPayApplyResult Data Structure.
    /// </summary>
    [Serializable]
    public class BankPayApplyResult : AopObject
    {
        /// <summary>
        /// 支付宝账户类型对应的id。如email、手机等
        /// </summary>
        [XmlElement("alipay_account_id")]
        public string AlipayAccountId { get; set; }

        /// <summary>
        /// 支付宝账户类型  ALIPAY_LOGON_ID:支付宝账户登录名  ALIPAY_USER_ID:支付宝账户userId
        /// </summary>
        [XmlElement("alipay_account_type")]
        public string AlipayAccountType { get; set; }

        /// <summary>
        /// 支付宝转账订单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 转账金额，单位为分
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 收到转账申请时间。精确到秒，格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [XmlElement("apply_time")]
        public string ApplyTime { get; set; }

        /// <summary>
        /// 银行订单号
        /// </summary>
        [XmlElement("bank_order_no")]
        public string BankOrderNo { get; set; }

        /// <summary>
        /// 业务订单号
        /// </summary>
        [XmlElement("biz_order_no")]
        public string BizOrderNo { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 转账渠道请求参数描述。如网银包括网银提交地址、网银提交方式、网银提交具体参数。参数以&分隔。
        /// </summary>
        [XmlElement("channel_desc")]
        public string ChannelDesc { get; set; }

        /// <summary>
        /// 转账备注信息。
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 订单状态描述  P:处理中  S:成功  F:失败
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 付款方卡账户类型  CP:对公  PI:对私
        /// </summary>
        [XmlElement("payer_card_account_type")]
        public string PayerCardAccountType { get; set; }

        /// <summary>
        /// 机构用户卡id标示，填写卡id类型对应的值。如email、手机等
        /// </summary>
        [XmlElement("payer_card_id")]
        public string PayerCardId { get; set; }

        /// <summary>
        /// 付款方卡id标示类型  BANK_ID：银行用户uid  BANK_CARD_NO:银行卡号
        /// </summary>
        [XmlElement("payer_card_id_type")]
        public string PayerCardIdType { get; set; }

        /// <summary>
        /// 付款方卡账户类型  DC:借记卡  CC:贷记卡
        /// </summary>
        [XmlElement("payer_card_type")]
        public string PayerCardType { get; set; }

        /// <summary>
        /// 机构简称，由支付宝定义  CMBC:民生银行
        /// </summary>
        [XmlElement("payer_inst_id")]
        public string PayerInstId { get; set; }

        /// <summary>
        /// 转账完成时间。精确到秒，格式为：yyyy-MM-dd HH:mm:ss。转账处理中该字段为空
        /// </summary>
        [XmlElement("success_time")]
        public string SuccessTime { get; set; }
    }
}
