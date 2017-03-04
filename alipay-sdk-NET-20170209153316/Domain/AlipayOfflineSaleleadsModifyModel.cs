using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineSaleleadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineSaleleadsModifyModel : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 商户品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 行业大类
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 行业三级分类
        /// </summary>
        [XmlElement("detail_category_id")]
        public string DetailCategoryId { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 需要修改leadsID
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 商户营业执照名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人PID
        /// </summary>
        [XmlElement("ope_pid")]
        public string OpePid { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 全局唯一的流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 门店数
        /// </summary>
        [XmlElement("scale")]
        public string Scale { get; set; }

        /// <summary>
        /// 门店信息json字符串
        /// </summary>
        [XmlElement("shop_info")]
        public string ShopInfo { get; set; }

        /// <summary>
        /// 行业小类
        /// </summary>
        [XmlElement("sub_category_id")]
        public string SubCategoryId { get; set; }
    }
}
