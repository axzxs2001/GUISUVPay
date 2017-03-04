using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserMemberCardUpdateResponse.
    /// </summary>
    public class AlipayUserMemberCardUpdateResponse : AopResponse
    {
        /// <summary>
        /// 请求失败时，不存在本参数；
        /// </summary>
        [XmlElement("card")]
        public string Card { get; set; }

        /// <summary>
        /// 返回结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 处理结果描述
        /// </summary>
        [XmlElement("result_msg")]
        public string ResultMsg { get; set; }
    }
}
