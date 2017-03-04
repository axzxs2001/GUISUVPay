using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskDirectionalIpprofileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskDirectionalIpprofileQueryModel : AopObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [XmlElement("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
