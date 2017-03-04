using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaoMaEntity
{
    /// <summary>
    /// 微信扫码查询订单返回
    /// </summary>
    public class WXSMQueryOrderBack
    {
        /// <summary>
        /// 交易类型 JSAPI--公众号支付、NATIVE--原生扫码支付、APP--app支付，MICROPAY--刷卡支付，
        /// </summary>
        public string TradeType
        {
            get; set;
        }
        /// <summary>
        /// 交易状态 SUCCESS—支付成功 REFUND—转入退款 NOTPAY—未支付  CLOSED—已关闭 REVOKED—已撤销（刷卡支付） USERPAYING--用户支付中  PAYERROR--支付失败
        /// </summary>
        public string TradeState
        {
            get; set;
        }
        /// <summary>
        /// 支付完成时间 
        /// </summary>
        public DateTime TimeEnd
        {
            get; set;
        }
        /// <summary>
        /// 商户订单号 
        /// </summary>
        public string OrderNo
        {
            get; set;
        }
    }
}
