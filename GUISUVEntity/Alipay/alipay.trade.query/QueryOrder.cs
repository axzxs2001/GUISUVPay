using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 查询实体类
    /// </summary>
    public class QueryOrder
    {
        /// <summary>
        /// 订单支付时传入的商户订单号,和支付宝交易号不能同时为空。 trade_no,out_trade_no如果同时存在优先取trade_no  特殊可选 64
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
