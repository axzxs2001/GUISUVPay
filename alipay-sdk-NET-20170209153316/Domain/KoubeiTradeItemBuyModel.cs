using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiTradeItemBuyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeItemBuyModel : AopObject
    {
        /// <summary>
        /// 若无现价则此值传商品原价，交易创建将根据此价格进行售卖。  传入的价格最多可有两位小数，最大值不可超过5000，超过则会报错。
        /// </summary>
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 额外描述信息，比如预定时间信息，需要以“字段1：描述1；字段2：描述2；....“方式传入。标点符号限制集如下,不能传下列标点之外的标点符号：..！.{},:()"[]，。!！,/>"{},:"，?？。!！\[\]]=+_@#$%*
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 原价，传入的价格最多可有两位小数，超过则会报错
        /// </summary>
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 外部业务流水编号,推荐:yyyymmddhhmmssSSS99999999(年月日时分秒+8位随机码)，开发者可根据该编号与口碑订单一一对应。本订单创建行为的流水ID,用于平台做幂等控制
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 购买数量，最大传入20，否则下单页会报错
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 店铺ID，用于后续统计商家各门店的售卖，需传入口碑店铺id，取值规则见FAQ常见问题。https://doc.open.alipay.com/docs/doc.htm?&docType=1&articleId=105746
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
