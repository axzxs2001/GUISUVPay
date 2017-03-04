using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMemberCardDeletecardResponse.
    /// </summary>
    public class AlipayMemberCardDeletecardResponse : AopResponse
    {
        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 返回码描述
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// T：成功  F：失败
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
