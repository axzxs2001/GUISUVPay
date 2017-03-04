using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMallPageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallPageModifyModel : AopObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈访问地址
        /// </summary>
        [XmlElement("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// 外部业务唯一id（用于幂等控制）
        /// </summary>
        [XmlElement("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
