using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopMenuDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMenuDeleteModel : AopObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [XmlElement("menu_id")]
        public string MenuId { get; set; }
    }
}
