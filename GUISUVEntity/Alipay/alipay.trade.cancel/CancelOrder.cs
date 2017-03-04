using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 撤销订单
    /// </summary>
    public class CancelOrder
    {
        /// <summary>
        ///原支付请求的商户订单号,和支付宝交易号不能同时为空  特殊可选 64
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝交易号，和商户订单号不能同时为空  特殊可选  64
        /// </summary>
        public string Trade_No
        {
            get;
            set;
        }
    }
}
