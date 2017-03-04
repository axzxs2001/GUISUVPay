using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCardTemplateCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCardTemplateCreateModel : AopObject
    {
        /// <summary>
        /// 业务卡号前缀，由商户自定义
        /// </summary>
        [XmlElement("biz_no_prefix")]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀长度，最大int值不能超过32-biz_no_suffix长度
        /// </summary>
        [XmlElement("biz_no_suffix_len")]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// 卡级别配置
        /// </summary>
        [XmlArray("card_level_conf")]
        [XmlArrayItem("template_card_level_conf_d_t_o")]
        public List<TemplateCardLevelConfDTO> CardLevelConf { get; set; }

        /// <summary>
        /// 卡类型为固定枚举类型，可选类型如下：  OUT_MEMBER_CARD：外部权益卡
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        [XmlArray("column_info_list")]
        [XmlArrayItem("template_column_info_d_t_o")]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// 字段规则列表，会员卡开卡过程中，会员卡信息的生成规则，  例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE
        /// </summary>
        [XmlArray("field_rule_list")]
        [XmlArrayItem("template_field_rule_d_t_o")]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// 会员卡用户领卡配置，在门店等渠道露出领卡入口时，需要部署的商户领卡H5页面地址
        /// </summary>
        [XmlElement("open_card_conf")]
        public TemplateOpenCardConfDTO OpenCardConf { get; set; }

        /// <summary>
        /// 卡模板投放渠道
        /// </summary>
        [XmlArray("pub_channels")]
        [XmlArrayItem("pub_channel_d_t_o")]
        public List<PubChannelDTO> PubChannels { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务Code  HUABEI_FUWU：花呗服务（只有需要花呗服务时，才需要加入该标识）
        /// </summary>
        [XmlArray("service_label_list")]
        [XmlArrayItem("string")]
        public List<string> ServiceLabelList { get; set; }

        /// <summary>
        /// 会员卡上架门店id（支付宝门店id），既发放会员卡的商家门店id
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 权益信息，  1、在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权，  2、如果添加门店渠道，则可在门店页展现会员卡的权益
        /// </summary>
        [XmlArray("template_benefit_info")]
        [XmlArrayItem("template_benefit_info_d_t_o")]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// 模板样式信息
        /// </summary>
        [XmlElement("template_style_info")]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// 卡包详情页面中展现出的卡码（可用于扫码核销）  qrcode: 二维码  dqrcode: 动态二维码  barcode: 条码  dbarcode: 动态条码  text: 文本
        /// </summary>
        [XmlElement("write_off_type")]
        public string WriteOffType { get; set; }
    }
}
