using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    public class PrecreateBack
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
        /// 商户订单号  必填 64
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 当前预下单请求生成的二维码码串，可以用二维码生成工具根据该码串值生成对应的二维码  必填  1024 

        /// </summary>
        public string Qr_Code
        {
            get;
            set;

        }
    }
}
