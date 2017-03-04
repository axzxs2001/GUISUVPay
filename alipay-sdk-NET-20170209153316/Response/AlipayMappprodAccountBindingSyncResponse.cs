using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMappprodAccountBindingSyncResponse.
    /// </summary>
    public class AlipayMappprodAccountBindingSyncResponse : AopResponse
    {
        /// <summary>
        /// 绑定结果, JSON字符串。预留，暂时没用。
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
