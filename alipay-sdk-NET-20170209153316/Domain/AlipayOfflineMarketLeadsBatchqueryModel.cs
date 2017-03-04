using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsBatchqueryModel : AopObject
    {
        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 最细的类目编号
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 筛选记录创建时间的结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 支付宝leads ID列表，最多一次查询100个leads详情。
        /// </summary>
        [XmlArray("leads_ids")]
        [XmlArrayItem("string")]
        public List<string> LeadsIds { get; set; }

        /// <summary>
        /// 若不以request_ids或者leads_ids查询，则此参数必填。PUBLIC：公海查询 PRIVATE：私海查询
        /// </summary>
        [XmlElement("leads_range")]
        public string LeadsRange { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 页码，留空标示第一页，默认20个结果为一页
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页记录数，默认20，最大100
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 请求ID，根据请求ID精确查询，最多一次查询100个leads详情。
        /// </summary>
        [XmlArray("request_ids")]
        [XmlArrayItem("string")]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 门店标签，注意传多个分店信息无法匹配
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 筛选记录创建时间的起始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// Leads状态。INIT：未认领，CLAIMED：已认领，CONFIRMING：待商户确认，RELATED：已关联商户，OPENING：开店中，OPENED：已开店
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
