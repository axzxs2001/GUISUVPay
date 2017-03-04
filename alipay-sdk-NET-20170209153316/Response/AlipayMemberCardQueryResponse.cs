using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMemberCardQueryResponse.
    /// </summary>
    public class AlipayMemberCardQueryResponse : AopResponse
    {
        /// <summary>
        /// 请求失败时，不存在本参数；  请求成功时，本参数不为空，json格式，目前支持如下key：  bizCardNo（支付宝会员卡卡号，用户会员卡存在时，该属性不为空）  openDate(会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss，用户会员卡存在时，该属性不为空)  validDate(会员卡有效期，格式为yyyy-MM-dd HH:mm:ss，本参数为空代表永久有效)  level(会员卡等级，由商户自定义)  point(会员卡积分)  pCardBalance(资金卡余额，单位：元，精确到小数点后两位)。
        /// </summary>
        [XmlElement("card")]
        public string Card { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数为错误代码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 请求成功时，不存在本参数；  请求失败时，本参数返回具体的错误原因。
        /// </summary>
        [XmlElement("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 请求是否成功。  T代表成功   F代表失败
        /// </summary>
        [XmlElement("success")]
        public string Success { get; set; }
    }
}
