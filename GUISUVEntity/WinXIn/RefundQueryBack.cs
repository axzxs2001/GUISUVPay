using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 查询退款Back
    /// </summary>
    public class RefundQueryBack
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string Return_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Return_Msg
        {
            get;
            set;
        }
        /// <summary>
        /// 业务结果
        /// </summary>
        public string Result_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误码
        /// </summary>
        public string Err_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误描述
        /// </summary>
        public string Err_Code_Des
        {
            get;
            set;
        }      
       
       
        /// <summary>
        /// 微信订单号   必填  32
        /// </summary>
        public string Transaction_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号  必填  32
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 订单金额   必填  100
        /// </summary>
        public int Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 应结订单金额   100
        /// </summary>
        public int Settlement_Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 货币种类     8
        /// </summary>
        public string Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 现金支付金额  必填  100
        /// </summary>
        public int Cash_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 退款笔数     必填  1
        /// </summary>
        public int Refund_Count
        {
            get;
            set;
        }
        /// <summary>
        /// 商户退款单号  必填  32
        /// </summary>
        public string Out_Refund_No_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 微信退款单号      必填  28
        /// </summary>
        public string Refund_Id_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款渠道    16
        /// </summary>
        public string Refund_Channel_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 申请退款金额    必填  100
        /// </summary>
        public int Refund_Fee_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款金额    100
        /// </summary>
        public int Settlement_Refund_Fee_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款资金来源    30
        /// </summary>
        public string Refund_Account_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券类型     CASH
        /// </summary>
        public int Coupon_Type_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 总代金券退款金额    100
        /// </summary>
        public int Coupon_Refund_Fee_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款代金券使用数量   1
        /// </summary>
        public int Coupon_Refund_Count_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款代金券ID    20
        /// </summary>
        public string Coupon_Refund_Id_Sn_Sm
        {
            get;
            set;
        }
        /// <summary>
        /// 单个代金券退款金额   100
        /// </summary>
        public int Coupon_Refund_Fee_Sn_Sm
        {
            get;
            set;
        }
        /// <summary>
        /// 退款状态    必填  16
        /// </summary>
        public string Refund_Status_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款入账账户   必填  64
        /// </summary>
        public string Refund_Recv_Accout_Sn
        {
            get;
            set;
        }
    }
}
