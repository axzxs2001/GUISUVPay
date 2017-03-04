using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMemberDataOauthQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMemberDataOauthQueryModel : AopObject
    {
        /// <summary>
        /// 授权业务类型
        /// </summary>
        [XmlElement("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展参数
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }
    }
}
