using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopDishDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopDishDeleteModel : AopObject
    {
        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }
    }
}
