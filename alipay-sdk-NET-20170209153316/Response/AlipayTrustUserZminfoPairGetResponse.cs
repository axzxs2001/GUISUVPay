using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTrustUserZminfoPairGetResponse.
    /// </summary>
    public class AlipayTrustUserZminfoPairGetResponse : AopResponse
    {
        /// <summary>
        /// 申请者芝麻信用信息JSON串
        /// </summary>
        [XmlElement("apply_zm_info")]
        public string ApplyZmInfo { get; set; }

        /// <summary>
        /// 信息失效时间
        /// </summary>
        [XmlElement("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 被申请者芝麻信用信息JSON串
        /// </summary>
        [XmlElement("owner_zm_info")]
        public string OwnerZmInfo { get; set; }
    }
}
