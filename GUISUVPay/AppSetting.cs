namespace SUISUVPay
{
    /// <summary>
    /// 参数类，对应appsettings.json
    /// </summary>
    public class AppSetting
    { 

        #region 公共参数
        /// <summary>
        /// 微信回调使用本接口的程序url
        /// </summary>
        public string WXNoticeCallBackUrl
        { get; set; }
        /// <summary>
        /// 支付宝回调使用本接口的程序url
        /// </summary>
        public string AlipayNoticeCallBackUrl
        { get; set; }
        /// <summary>
        /// 支付平台所在域名或公网IP地址
        /// </summary>
        public string DomainName
        { get; set; }
        #endregion
        #region 微信参数
        /// <summary>
        /// 微信appid
        /// </summary>
        public string WXAppID
        { get; set; }
        /// <summary>
        /// 微信mchid
        /// </summary>
        public string WXMchid
        { get; set; }
        /// <summary>
        /// 微信key
        /// </summary>
        public string WXKey
        {
            get; set;
        }
        /// <summary>
        /// 微信app secert
        /// </summary>
        public string WXAppSecert
        { get; set; }
        /// <summary>
        /// 微信ssl cert path
        /// </summary>
        public string WXSSLCertPath
        { get; set; }
        /// <summary>
        /// 微信ssl cert password
        /// </summary>
        public string WXSSLCertPassword
        { get; set; }
        #endregion
        #region 支付宝参数
        /// <summary>
        /// 支付宝appid
        /// </summary>
        public string AlipayAppid
        { get; set; }
        /// <summary>
        /// 支付宝pid
        /// </summary>
        public string AlipayPid
        { get; set; }
        #endregion

    }
}
