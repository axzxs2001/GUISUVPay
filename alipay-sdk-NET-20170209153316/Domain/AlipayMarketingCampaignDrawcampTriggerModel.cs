using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampTriggerModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDrawcampTriggerModel : AopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 用户登录号/用户uid，非脱敏账号
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
