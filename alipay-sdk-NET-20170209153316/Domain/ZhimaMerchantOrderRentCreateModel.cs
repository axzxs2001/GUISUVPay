using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentCreateModel : AopObject
    {
        /// <summary>
        /// 借用周期，必须是正整数
        /// </summary>
        [XmlElement("borrow_cycle")]
        public string BorrowCycle { get; set; }

        /// <summary>
        /// 借用周期单位：  HOUR:小时  DAY:天
        /// </summary>
        [XmlElement("borrow_cycle_unit")]
        public string BorrowCycleUnit { get; set; }

        /// <summary>
        /// 物品借用门店
        /// </summary>
        [XmlElement("borrow_shop_name")]
        public string BorrowShopName { get; set; }

        /// <summary>
        /// 押金
        /// </summary>
        [XmlElement("deposit_amount")]
        public string DepositAmount { get; set; }

        /// <summary>
        /// 是否允许不准入的用户支持支付押金借用:  Y:支持  N:不支持
        /// </summary>
        [XmlElement("deposit_state")]
        public string DepositState { get; set; }

        /// <summary>
        /// 物品名称,最长不能超过14个汉字
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 回调到商户的url地址
        /// </summary>
        [XmlElement("invoke_return_url")]
        public string InvokeReturnUrl { get; set; }

        /// <summary>
        /// 商户发起借用服务时，需要在借用结束后返回给商户的参数
        /// </summary>
        [XmlElement("invoke_state")]
        public string InvokeState { get; set; }

        /// <summary>
        /// 商户访问蚂蚁的对接模式：  WINDOWS-支付宝服务窗
        /// </summary>
        [XmlElement("invoke_type")]
        public string InvokeType { get; set; }

        /// <summary>
        /// 废弃，使用蚂蚁开放平台应用中的网关地址
        /// </summary>
        [XmlElement("notify_url")]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 外部订单号，需要唯一，由商户传入，芝麻内部会做幂等控制，格式为：yyyyMMddHHmmss+随机数
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 租金，同时也是物品价值，用户需根据该字段金额进行赔偿  :  >0.00元，代表有租金  <=0.00元或者为空，代表没有租金
        /// </summary>
        [XmlElement("rent_amount")]
        public string RentAmount { get; set; }

        /// <summary>
        /// 租金信息描述 ,长度14个汉字，只用于页面展示给C端用户
        /// </summary>
        [XmlElement("rent_info")]
        public string RentInfo { get; set; }

        /// <summary>
        /// 租金单位：  DAY_YUAN:元/天  HOUR_YUAN:元/小时
        /// </summary>
        [XmlElement("rent_unit")]
        public string RentUnit { get; set; }
    }
}
