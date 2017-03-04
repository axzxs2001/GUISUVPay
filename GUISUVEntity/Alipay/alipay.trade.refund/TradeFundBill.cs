namespace SUISUVPayEntity.Alipay
{
    public class TradeFundBill
    {
        /// <summary>
        /// 交易使用的资金渠道，详见 支付渠道列表   必填  32 
        /// </summary>
        public string Fund_Channel
        {
            get;
            set;
        }
        /// <summary>
        /// 该支付工具类型所使用的金额  选填  - 
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 渠道实际付款金额   选填  11 
        /// </summary>
        public decimal Real_Amount
        {
            get;
            set;
        }
    }
}