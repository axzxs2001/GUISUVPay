using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 支付宝退款返回实体
    /// </summary>
    public class RefundBack
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
        /// 2013112011001004330000121536  必填 64 
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
        /// 买家支付宝用户号，该参数已废弃，请不要使用  必填 32 
        /// </summary>
        public string Open_Id
        {
            get;
            set;
        }
        /// <summary>
        ///        用户的登录id 必填 100 
        /// </summary>
        public string Buyer_Logon_Id
        {
            get;
            set;
        }
        /// <summary>
          ///本次退款是否发生了资金变化   必填 1 
          /// </summary>
        public string Fund_Change
        {
            get;
            set;
        }
        /// <summary>
        ///退款总金额  必填 11 
        /// </summary>
        public string Refund_Fee 
        {
            get;
            set;
        }
        /// <summary>
        /// 退款支付时间 必填 32 

        /// </summary>
        public DateTime Gmt_Refund_Pay
        {
            get;
            set;
        }
        /// <summary>
        /// 退款使用的资金渠道 选填 - 
        /// </summary>
        public List<TradeFundBill> Refund_Detail_Item_List
        {
            get;
            set;
        }
        /// <summary>
        /// 交易在支付时候的门店名称  选填 512 

        /// </summary>
        public string Store_Name
        {
            get;
            set;
        }
        /// <summary>
        /// 买家在支付宝的用户id 必填 28 
        /// </summary>
        public string Buyer_User_Id
        {
            get;
            set;
        }



    }
}
