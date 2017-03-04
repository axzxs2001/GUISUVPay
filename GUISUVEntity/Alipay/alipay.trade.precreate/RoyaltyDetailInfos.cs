namespace SUISUVPayEntity.Alipay
{
    public class RoyaltyDetailInfos
    {       /// <summary>
            /// 分账序列号，表示分账执行的顺序，必须为正整数 可选 9 
            /// </summary>
        public int Serial_No
        {
            get;
            set;
        }
        /// <summary>
        /// 接受分账金额的账户类型：  userId：支付宝账号对应的支付宝唯一用户号。  bankIndex：分账到银行账户的银行编号。目前暂时只支持分账到一个银行编号。 storeId：分账到门店对应的银行卡编号。 默认值为userId。 可选  24 
        /// </summary>
        public string Trans_In_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 分账批次号 分账批次号。 目前需要和转入账号类型为bankIndex配合使用。 必填 32 
        /// </summary>
        public string Batch_No
        {
            get;
            set;
        }
        /// <summary>
        /// 商户分账的外部关联号，用于关联到每一笔分账信息，商户需保证其唯一性。 如果为空，该值则默认为“商户网站唯一订单号+分账序列号”     可选  64 
        /// </summary>
        public string Out_Relation_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 要分账的账户类型。 目前只支持userId：支付宝账号对应的支付宝唯一用户号。 默认值为userId。   必填 24 
        /// </summary>
        public string Trans_Out_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 如果转出账号类型为userId，本参数为要分账的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  必填 16 
        /// </summary>
        public string Trans_Out
        {
            get;
            set;
        }
        /// <summary>
        /// 如果转入账号类型为userId，本参数为接受分账金额的支付宝账号对应的支付宝唯一用户号。以2088开头的纯16位数字。  如果转入账号类型为bankIndex，本参数为28位的银行编号（商户和支付宝签约时确定）。 如果转入账号类型为storeId，本参数为商户的门店ID。  必填  28 
        /// </summary>
        public string Trans_In
        {
            get;
            set;
        }
        /// <summary>
        /// 分账的金额，单位为元   必填 9
        /// </summary>
        public decimal Amount
        {
            get;
            set;
        }
        /// <summary>
        /// 分账描述信息     可选  1000 
        /// </summary>
        public string Desc
        {
            get;
            set;
        }
        /// <summary>
        /// 分账的比例，值为20代表按20%的比例分账  可选 3
        /// </summary>
        public string Amount_Percentage
        {
            get;
            set;
        }
    }
}