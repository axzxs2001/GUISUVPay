namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 本交易支付时使用的所有优惠券信息 
    /// </summary>
    public class VoucherDetail
    {
        /// <summary>
        /// 券id  必填 32 
        /// </summary>
        public string Id
        {
            get;
            set;
        }
        /// <summary>
        /// 券名称  必填 64 
        /// </summary>
        public string Name
        {
            get;
            set;
        }
        /// <summary>
        /// 当前有三种类型： ALIPAY_FIX_VOUCHER - 全场代金券 ALIPAY_DISCOUNT_VOUCHER - 折扣券 ALIPAY_ITEM_VOUCHER - 单品优惠 注：不排除将来新增其他类型的可能，商家接入时注意兼容性避免硬编码   必填  32 
        /// </summary>
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// 优惠券面额，它应该会等于商家出资加上其他出资方出资   必填  8 
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }
        /// <summary>
        ///  商家出资（特指发起交易的商家出资金额）  选填 8 
        /// </summary>
        public decimal Merchant_Contribute
        {
            get;
            set;
        }
        /// <summary>
        /// 其他出资方出资金额，可能是支付宝，可能是品牌商，或者其他方，也可能是他们的一起出资 选填 8 
        /// </summary>
        public decimal Other_Contribute
        {
            get;
            set;
        }
        /// <summary>
        /// 优惠券备注信息  选填 256 
        /// </summary>
        public string Memo
        {
            get;
            set;
        }
    }
}