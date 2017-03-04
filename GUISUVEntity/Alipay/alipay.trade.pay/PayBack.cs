using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 统一收单交易支付接口（条码支付）返回实体
    /// </summary>
    public class PayBack
    {
        /// <summary>
        /// 网关返回码,详见文档  必填 -
        /// </summary>
        public string Code
        {
            get;
            set;
        }
        /// <summary>
        /// 网关返回码描述,详见文档 必填 -
        /// </summary>
        public string Msg
        {
            get;
            set;
        }
        /// <summary>
        /// 业务返回码,详见文档  -
        /// </summary>
        public string Sub_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 业务返回码描述,详见文档 -
        /// </summary>
        public string Sub_Msg
        {
            get;
            set;
        }   
        /// <summary>
        /// 支付宝交易号 必填 64 
        /// </summary>
        public string Trade_No
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
        /// 买家支付宝账号 必填 100 
        /// </summary>
        public string Buyer_Logon_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 交易金额 必填 11
        /// </summary>
        public string Total_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 实收金额 必填 11
        /// </summary>
        public decimal Receipt_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 买家付款的金额   选填 11 
        /// </summary>
        public decimal Buyer_Pay_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 使用积分宝付款的金额 选填 11 
        /// </summary>
        public decimal Point_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 交易中可给用户开具发票的金额 选填 11 
        /// </summary>
        public decimal Invoice_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 交易支付时间  必填 32 
        /// </summary>
        public DateTime Gmt_Payment
        {
            get;
            set;
        }
        ///<summary>
        /// 交易支付使用的资金渠道  必填 - 
        /// </summary>
        public List<TradeFundBill> Fund_Bill_List
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝卡余额  选填 11 
        /// </summary>
        public decimal Card_Balance
        {
            get;
            set;
        }
        /// <summary>
        /// 发生支付交易的商户门店名称 选填 512
        /// </summary>
        public string Store_Name
        {
            get;
            set;
        }
        /// <summary>
        /// 买家在支付宝的用户id 必填 28 
        /// </summary>
        public string Buyer_User_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息 必填 - 
        /// </summary>
        public string Discount_Goods_Detail
        {
            get;
            set;
        }
        /// <summary>
        /// 本交易支付时使用的所有优惠券信息   选填 - 
        /// </summary>
        public List<VoucherDetail> Voucher_Detail_List

        {
            get;
            set;
        }

    }
}
