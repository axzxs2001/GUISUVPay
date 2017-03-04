using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdFingerprintApplyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdFingerprintApplyModel : AopObject
    {
        /// <summary>
        /// ifaf_message:注册阶段客户端返回的协议体数据，对应《IFAA本地免密技术规范》中的IFAFMessage，内容中包含客户端的校验数据。
        /// </summary>
        [XmlElement("ifaf_message")]
        public string IfafMessage { get; set; }

        /// <summary>
        /// 外部业务号，商户的业务单据号，用于核对与问题排查
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
