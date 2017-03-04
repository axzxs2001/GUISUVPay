namespace SUISUVPayEntity.Alipay
{
    /// <summary>
    /// 业务扩展参数
    /// </summary>
    public class ExtendParams
    {
        /// <summary>
        /// 系统商编号 该参数作为系统商返佣数据提取的依据，请填写系统商签约协议的PID  可选 64 
        /// </summary>
        public string Sys_Service_Provider_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 使用花呗分期要进行的分期数  可选  5
        /// </summary>
        public string hb_fq_num
        {
            get;
            set;
        }
        /// <summary>
        /// 使用花呗分期需要卖家承担的手续费比例的百分值，传入100代表100%  可选 3 
        /// </summary>
        public string Hb_Fq_Seller_Percent
        {
            get;
            set;
        }
    }
}