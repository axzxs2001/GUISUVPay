using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    public class QueryOrderBack
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
        /// 交易状态
        /// </summary>
        public string Trade_Status
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
        /// 本次交易打款给卖家的时间 32
        /// </summary>
        public DateTime Send_Pay_Date
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝店铺编号 64
        /// </summary>
        public string Alipay_Store_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 商户门店编号 32
        /// </summary>
        public string Store_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 商户机具终端编号 32
        /// </summary>
        public string Terminal_ID
        {
            get; set;
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
        /// 请求交易支付中的商户店铺的名称 选填 512
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
        /// 行业特殊信息（例如在医保卡支付业务中，向用户返回医疗信息）。 选填 4096 

        /// </summary>
        public string Industry_Sepc_Detail
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
