using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineProviderShopactionRecordModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineProviderShopactionRecordModel : AopObject
    {
        /// <summary>
        /// json格式，操作详情（根据操作类型不同而不同）（太大的话可能会导致内部处理失败）
        /// </summary>
        [XmlElement("action_detail")]
        public string ActionDetail { get; set; }

        /// <summary>
        /// 本次请求的唯一键（操作实体主键+平台字符串）
        /// </summary>
        [XmlElement("action_outer_id")]
        public string ActionOuterId { get; set; }

        /// <summary>
        /// 操作类型（insert_table/update_table/insert_dish/delete_dish/soldout_dish/modify_dish/modify_shop_status）
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 商户行为发生时间 格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("date_time")]
        public string DateTime { get; set; }

        /// <summary>
        /// 操作实体（实体+操作类型决定一个真正的操作【店铺+新增、座位+修改、店铺+适时状态等等】）
        /// </summary>
        [XmlElement("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// 所属行业 (餐饮：REPAST)
        /// </summary>
        [XmlElement("industry")]
        public string Industry { get; set; }

        /// <summary>
        /// 操作的店铺对象
        /// </summary>
        [XmlElement("outer_shop_do")]
        public OuterShopDO OuterShopDo { get; set; }
    }
}
