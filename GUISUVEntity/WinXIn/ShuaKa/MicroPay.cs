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
    public class MicroPay
    {

        /// <summary>
        /// 商品描述
        /// </summary>
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// 商品详情    6000
        /// </summary>
        public string Detail
        {
            get;
            set;
        }
        /// <summary>
        /// 附加数据   127
        /// </summary>
        public string Attach
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号  必填  32
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 订单金额    必填 888
        /// </summary>
        public int Total_Fee
        {
            get;
            set;
        }
        /// <summary>
        /// 货币类型   16
        /// </summary>
        public string Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 商品标记   32
        /// </summary>
        public string Goods_Tag
        {
            get;
            set;
        }
        /// <summary>
        /// 授权码   必填  128
        /// </summary>
        public string Auth_Code
        {
            get;
            set;
        }
    }
}
