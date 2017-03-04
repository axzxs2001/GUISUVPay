using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// UseRule Data Structure.
    /// </summary>
    [Serializable]
    public class UseRule : AopObject
    {
        /// <summary>
        /// 扩展属性，无需设置
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券的不可用时间
        /// </summary>
        [XmlElement("forbidden_time")]
        public ForbbidenTime ForbiddenTime { get; set; }

        /// <summary>
        /// 券核销的最低消费门槛，单位元
        /// </summary>
        [XmlElement("min_consume")]
        public string MinConsume { get; set; }

        /// <summary>
        /// 券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店
        /// </summary>
        [XmlArray("suit_shops")]
        [XmlArrayItem("string")]
        public List<string> SuitShops { get; set; }

        /// <summary>
        /// 券可用时间段
        /// </summary>
        [XmlArray("use_time")]
        [XmlArrayItem("use_time")]
        public List<UseTime> UseTime { get; set; }
    }
}
