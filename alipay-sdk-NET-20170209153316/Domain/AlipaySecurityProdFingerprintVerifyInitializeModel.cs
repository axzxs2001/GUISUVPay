using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintVerifyInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFingerprintVerifyInitializeModel : AopObject
    {
        /// <summary>
        /// IFAA协议的版本，目前为2.0
        /// </summary>
        [XmlElement("ifaa_version")]
        public string IfaaVersion { get; set; }

        /// <summary>
        /// IFAA标准中用于关联IFAA Server和业务方Server开通状态的token，此token为注册时保存的token，传入此token，用于生成服务端校验信息。
        /// </summary>
        [XmlElement("token")]
        public string Token { get; set; }
    }
}
