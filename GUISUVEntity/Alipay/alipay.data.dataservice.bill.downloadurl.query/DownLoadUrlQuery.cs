using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    public class DownLoadUrlQuery
    {
        /// <summary>
        /// 账单类型，商户通过接口或商户经开放平台授权后其所属服务商通过接口可以获取以下账单类型：trade、signcustomer；trade指商户基于支付宝交易收单的业务账单；signcustomer是指基于商户支付宝余额收入及支出等资金变动的帐务账单； 必填 10 
        /// </summary>
        public string Bill_Type
        {
            get;
            set;

        }
        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd，月账单格式为yyyy-MM。 必填 15
        /// </summary>
        public string Bill_Date
        {
            get;
            set;

        }
    }
}
