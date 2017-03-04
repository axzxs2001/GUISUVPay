using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 支付宝退款实体类
    /// </summary>
    public class Refund
    {
        /// <summary>
        ///  订单支付时传入的商户订单号,不能和 trade_no同时为空。  特殊可选 64
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
        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数  必须 9
        /// </summary>
        public decimal Refund_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 退款的原因说明  可选 256
        /// </summary>
        public string Refund_Reason
        {
            get;
            set;
        }
        /// <summary>
        /// 标识一次退款请求，同一笔交易多次退款需要保证唯一，如需部分退款，则此参数必传。 可选 64
        /// </summary>
        public string Out_Request_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商户的操作员编号 可选 30
        /// </summary>
        public string Operator_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户的门店编号 可选 32
        /// </summary>
        public string Store_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户的终端编号  可选 32
        /// </summary>
        public string Terminal_Id
        {
            get;
            set;
        } 
    }
}
