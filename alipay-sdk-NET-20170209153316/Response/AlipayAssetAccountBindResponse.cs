using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAssetAccountBindResponse.
    /// </summary>
    public class AlipayAssetAccountBindResponse : AopResponse
    {
        /// <summary>
        /// 用户的支付宝账号对应的支付宝唯一用户标识，不可变更。
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 使用该app提供用户信息的商户，可以和app相同。
        /// </summary>
        [XmlElement("provider_id")]
        public string ProviderId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员标识。商户需确保其唯一性，不可变更。
        /// </summary>
        [XmlElement("provider_user_id")]
        public string ProviderUserId { get; set; }

        /// <summary>
        /// 用户在商户网站的会员名（登录号或昵称）。
        /// </summary>
        [XmlElement("provider_user_name")]
        public string ProviderUserName { get; set; }
    }
}
