using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    public class Precreate
    {
        /// <summary>
        /// 设备标识
        /// </summary>
        public string DeviceID
        { get; set; }
        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复 必选 64
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 卖家支付宝用户ID。 如果该值为空，则默认为商户签约账号对应的支付宝用户ID   可选 28
        /// </summary>
        public string Seller_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果同时传入了【打折金额】，【不可打折金额】，【订单总金额】三者，则必须满足如下条件：【订单总金额】=【打折金额】+【不可打折金额】 必须 11
        /// </summary>
        public decimal Total_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 可打折金额. 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果该值未传入，但传入了【订单总金额】，【不可打折金额】则该值默认为【订单总金额】-【不可打折金额】 可选 11
        /// </summary>
        public decimal Discountable_Amount

        {
            get;
            set;
        }
        /// <summary>
        /// 不可打折金额. 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000] 如果该值未传入，但传入了【订单总金额】,【打折金额】，则该值默认为【订单总金额】-【打折金额】  
        /// 可选11 
        /// </summary>
        public decimal Undiscountable_Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 买家支付宝账号 可选 100
        /// </summary>
        public string Buyer_Logon_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 订单标题   必须 256
        /// </summary>
        public string Subject
        {
            get;
            set;
        }
        /// <summary>
        /// 对交易或商品的描述  可选 128
        /// </summary>
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// 订单包含的商品列表信息.Json格式. 其它说明详见：“商品明细说明  可选 -
        /// </summary>
        public List<GoodsDetail> Goods_Detail
        {
            get;
            set;
        }
        /// <summary>
        /// 商户操作员编号 可选 28
        /// </summary>
        public string Operator_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户门店编号 可选 32
        /// </summary>
        public string Store_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商户机具终端编号 可选 32
        /// </summary>
        public string Terminal_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 业务扩展参数  可选 -
        /// </summary>
        public List<ExtendParams> Extend_Params
        {
            get;
            set;
        }
        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。  可选 6

        /// </summary>
        public string Timeout_Express
        {
            get;
            set;
        }
        /// <summary>
        /// 描述分账信息，json格式。可选 -
        /// </summary>
        public List<RoyaltyInfo> Royalty_Info 
        {
            get;
            set;
        }
        /// <summary>
        /// 二级商户信息,当前只对特殊银行机构特定场景下使用此字段 可选 -
        /// </summary>
        public List<SubMerchant> Sub_Merchant
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝店铺的门店ID 可选 32
        /// </summary>
        public string Alipay_Store_Id
        {
            get;
            set;
        }
    }
}
