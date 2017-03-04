using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 申请退款Back
    /// </summary>
    public class RefundBack
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
        /// 错误代码
        /// </summary>
        public string Err_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string Err_Code_Des
        {
            get;
            set;
        }
    
        /// <summary>
        /// 微信订单号    必填  28
        /// </summary>
        public string Transaction_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号    必填  32
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商户退款单号   必填  32
        /// </summary>
        public string Out_Refund_No
        {
            get;
            set;
        }
        /// <summary>
        /// 微信退款单号  必填 28
        /// </summary>
        public string Refund_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 退款渠道     16
        /// </summary>
        public string Refund_Channel
        {
            get;
            set;
        }
        /// <summary>
        /// 退款金额   必填  100
        /// </summary>
        public int Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 应结退款金额    100
        /// </summary>
        public int Settlement_Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 标价金额   必填  100
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
        /// 标价币种    8
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
        /// 现金支付币种    16
        /// </summary>
        public string Cash_Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 现金退款金额   100
        /// </summary>
        public int Cash_Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券类型    8
        /// </summary>
        public string Coupon_Type_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券退款总金额   100
        /// </summary>
        public int Coupon_Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 单个代金券退款金额  100
        /// </summary>
        public int Coupon_Refund_Fee_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 退款代金券使用数量  1
        /// </summary>
        public int Coupon_Refund_Count
        {
            get;
            set;
        }
        /// <summary>
        /// 退款代金券ID   20
        /// </summary>
        public string Coupon_Refund_Id_Sn
        {
            get;
            set;
        }
    }
}
