using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMemberConsumeNotifyResponse.
    /// </summary>
    public class AlipayMemberConsumeNotifyResponse : AopResponse
    {
        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// card_user_info不能为空
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 外部会员卡
        /// </summary>
        [XmlElement("ext_card_no")]
        public string ExtCardNo { get; set; }

        /// <summary>
        /// T:成功，F：失败
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
