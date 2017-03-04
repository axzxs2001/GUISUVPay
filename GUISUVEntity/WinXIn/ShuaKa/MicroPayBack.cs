using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShuaKa
{
    /// <summary>
    /// 提交刷卡支付
    /// </summary>
    public class MicroPayBack
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
        /// 用户标识   必填  128
        /// </summary>
        public string Openid
        {
            get;
            set;
        }
        /// <summary>
        /// 是否关注公众账号  必填  1
        /// </summary>
        public string Is_Subscribe
        {
            get;
            set;
        }
        /// <summary>
        /// 交易类型  必填  16
        /// </summary>
        public string Trade_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 付款银行  必填  32
        /// </summary>
        public string Bank_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 货币类型   必填  16 CNY
        /// </summary>
        public string Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 订单金额  必填  888
        /// </summary>
        public int Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 应结订单金额  100
        /// </summary>
        public int Settlement_Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 代金券金额  100
        /// </summary>
        public int Coupon_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 现金支付货币类型  16 CNY
        /// </summary>
        public string Cash_Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 现金支付金额   必填  100
        /// </summary>
        public int Cash_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 微信支付订单号 必填  32
        /// </summary>
        public string Transaction_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号   必填  32
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商家数据包  必填  128
        /// </summary>
        public string Attach
        {
            get;
            set;
        }
        /// <summary>
        /// 支付完成时间  必填  14
        /// </summary>
        public string Time_End
        {
            get;
            set;
        }
    }
}
