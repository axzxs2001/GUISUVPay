using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 扫码异步通知
    /// </summary>
    public class PayResultNotify
    {
        /// <summary>
        ///通知时间  必填
        /// </summary>
        public DateTime Notify_Time
        {
            get;
            set;
        }
        /// <summary>
        /// 通知类型  必填 64
        /// </summary>
        public string Notify_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 通知校验ID  必填 128
        /// </summary>
        public string Notify_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 签名类型  必填 10
        /// </summary>
        public string Sign_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 签名  必填 256
        /// </summary>
        public string Sign 
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝交易号  必填 64
        /// </summary>
        public string Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 开发者的app_id  必填 32
        /// </summary>
        public string app_id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号  必填 64
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商户业务号  64
        /// </summary>
        public string Out_Biz_No
        {
            get;
            set;
        }
        /// <summary>
        /// 买家支付宝用户号  16
        /// </summary>
        public string Buyer_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 买家支付宝账号  100
        /// </summary>
        public string Buyer_Logon_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 卖家支付宝用户号  30
        /// </summary>
        public string Seller_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 交易状态  32
        /// </summary>
        public string Trade_Status
        {
            get;
            set;
        }
        /// <summary>
        /// 订单金额  
        /// </summary>
        public decimal Total_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 实收金额  
        /// </summary>
        public decimal Receipt_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 开票金额 
        /// </summary>
        public decimal Invoice_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 付款金额
        /// </summary>
        public decimal Buyer_Pay_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 集分宝金额
        /// </summary>
        public decimal Point_Amount
        {
            get;
            set;
        }

        /// <summary>
        /// 总退款金额  
        /// </summary>
        public decimal Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 实际退款金额
        /// </summary>
        public decimal Send_Back_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 订单标题  256 
        /// </summary>
        public string Subject
        {
            get;
            set;
        }
        /// <summary>
        /// 商品描述 400
        /// </summary>
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// 交易创建时间 
        /// </summary>
        public DateTime Gmt_Create
        {
            get;
            set;
        }
        /// <summary>
        /// 交易付款时间
        /// </summary>
        public DateTime Gmt_Payment
        {
            get;
            set;
        }
        /// <summary>
        /// 交易退款时间
        /// </summary>
        public DateTime Gmt_Refund
        {
            get;
            set;
        }
        /// <summary>
        ///交易结束时间 
        /// </summary>
        public DateTime Gmt_Close
        {
            get;
            set;
        }
        /// <summary>
        /// 支付金额信息 
        /// </summary>
        public string Fund_Bill_List
        {
            get;
            set;
        }
    }
}
