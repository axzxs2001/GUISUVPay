using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
   public   class CancelOrderBack
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
        /// 签名,详见文档 必填 -
        /// </summary>
        public string Sign
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
        /// 是否需要重试  必填 1
        /// </summary>
        public string Retry_Flag
        {
            get;
            set;
        }
        /// <summary>
        /// 本次撤销触发的交易动作 close：关闭交易，无退款 refund：产生了退款   必填  10 
        /// </summary>
        public string Action
        {
            get;
            set;
        }
    }
}
