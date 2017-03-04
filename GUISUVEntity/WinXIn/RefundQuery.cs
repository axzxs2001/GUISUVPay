using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 查询退款
    /// </summary>
    public class RefundQuery
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
        /// 商户订单号
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string Out_Refund_No
        {
            get;
            set;
        }
        /// <summary>
        /// 微信退款单号    必填  28
        /// </summary>
        public string Refund_Id
        {
            get;
            set;
        }
    }
}
