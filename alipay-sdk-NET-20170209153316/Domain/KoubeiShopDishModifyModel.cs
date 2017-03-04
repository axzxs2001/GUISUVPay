using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiShopDishModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopDishModifyModel : AopObject
    {
        /// <summary>
        /// 菜品描述，最多40个字
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称，同一商户下菜品名称不允许重复，最多12个字
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品价格 单位 元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 菜品标签列表，标签类型包括：菜属性、菜推荐，菜属性的值包括：重辣、中辣、微辣和清淡，菜推荐的值包括：热门HOT
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("dish_tag")]
        public List<DishTag> Tags { get; set; }
    }
}
