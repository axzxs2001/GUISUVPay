using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShaoMa
{
    /// <summary>
    /// 支付结果通知
    /// </summary>
    public class PayResultNotify
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
        /// 交易类型   必填  16
        /// </summary>
        public string Trade_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 付款银行    必填  16
        /// </summary>
        public string Bank_Type
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
        /// 货币种类   8
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
        /// 现金支付货币类型   CNY
        /// </summary>
        public string Cash_Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 总代金券金额   10
        /// </summary>
        public int Coupon_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券使用数量   1
        /// </summary>
        public int Coupon_Count
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券类型    CASH
        /// </summary>
        public int Coupon_Type_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券ID     20
        /// </summary>
        public string Coupon_Id_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 单个代金券支付金额   100
        /// </summary>
        public int Coupon_Fee_Sn
        {
            get;
            set;
        }
        /// <summary>
        /// 微信支付订单号  选必填 32
        /// </summary>
        public string Transaction_Id
        { get; set; }
        /// <summary>
        /// 商户订单号    选必填  32
        /// </summary>
        public string Out_Trade_No

        {
            get;
            set;
        }
        /// <summary>
        /// 商家数据包      128
        /// </summary>
        public string Attach
        {

            get;

            set;
        }
        /// <summary>
        /// 支付完成时间    必填  14
        /// </summary>
        public string Time_End
        {
            get;
            set;
        }
    }
}
