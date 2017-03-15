using System.Collections.Generic;

namespace SUISUVPay
{
    /// <summary>
    /// 参数类，对应appsettings.json
    /// </summary>
    public class AppSetting
    { 

        #region 公共参数
 
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
        /// <summary>
        /// 回调集合
        /// </summary>
        public List<BackNotify> BackNotifies
        { get; set; }

    }
    /// <summary>
    /// 通知实体类
    /// </summary>
    public class BackNotify
    {
        /// <summary>
        /// 设备ID
        /// </summary>
        public string DeviceID
        { get; set; }
        /// <summary>
        /// 通知URL
        /// </summary>
        public string NotifyUrl
        { get; set; }
    }
}
