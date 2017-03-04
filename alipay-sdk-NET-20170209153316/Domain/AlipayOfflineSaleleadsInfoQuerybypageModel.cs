using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsInfoQuerybypageModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsInfoQuerybypageModel : AopObject
    {
        /// <summary>
        /// 分配主体----服务商小二
        /// </summary>
        [XmlElement("assign_principal_id")]
        public string AssignPrincipalId { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 行业大类
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 三级分类
        /// </summary>
        [XmlElement("detail_category_id")]
        public string DetailCategoryId { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 查询截止时间，如果是公海查询表示创建时间，私海查询表示认领时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// leads名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        [XmlElement("ope_type")]
        public string OpeType { get; set; }

        /// <summary>
        /// 当前页，***注意页数从1开始***
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页容量：最小1，最大100
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 查询时间
        /// </summary>
        [XmlElement("query_time")]
        public string QueryTime { get; set; }

        /// <summary>
        /// 门店标签，注意传多个分店信息无法匹配
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 签约确认状态
        /// </summary>
        [XmlElement("sign_status")]
        public string SignStatus { get; set; }

        /// <summary>
        /// 查询起始时间，如果是公海查询表示创建时间，私海查询表示认领时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 行业小类
        /// </summary>
        [XmlElement("sub_category_id")]
        public string SubCategoryId { get; set; }
    }
}
