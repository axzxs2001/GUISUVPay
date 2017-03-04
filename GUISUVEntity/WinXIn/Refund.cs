using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 申请退款
    /// </summary>
    public class Refund
    {     
        /// <summary>
        /// 微信订单号   
        /// </summary>
        public string Transaction_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号  必填    32
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
        /// 订单金额(单位分)   必填   100
        /// </summary>
        public int Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 退款金额(单位分)     必填  100
        /// </summary>
        public int Refund_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 货币种类     8
        /// </summary>
        public string Refund_Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 退款资金来源   30
        /// </summary>
        public string Refund_Account
        {
            get;
            set;
        }
    }
}
