using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StaffDTO Data Structure.
    /// </summary>
    [Serializable]
    public class StaffDTO : AopObject
    {
        /// <summary>
        /// 行业类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 职员部门Id
        /// </summary>
        [XmlElement("bizunit_id")]
        public string BizunitId { get; set; }

        /// <summary>
        /// 员工邮箱
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// 服务商PID
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户唯一标识类型，与商户Id组合起来，唯一确定一个商户实体
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 员工PID
        /// </summary>
        [XmlElement("staff_biz_code")]
        public string StaffBizCode { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        [XmlElement("staff_id")]
        public string StaffId { get; set; }

        /// <summary>
        /// 员工手机号
        /// </summary>
        [XmlElement("staff_mobile")]
        public string StaffMobile { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [XmlElement("staff_name")]
        public string StaffName { get; set; }

        /// <summary>
        /// 员工类型
        /// </summary>
        [XmlElement("staff_type")]
        public string StaffType { get; set; }
    }
}
