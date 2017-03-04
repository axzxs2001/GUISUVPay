using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsCreateModel : AopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        [XmlElement("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌名称，如果传空或不存在，默认使用：其它品牌
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 品类id
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 营业执照上的公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// kp联系人职位，按照枚举值填写
        /// </summary>
        [XmlElement("contact_kp_job")]
        public string ContactKpJob { get; set; }

        /// <summary>
        /// kp联系人电话，只能填写一个，座机或者手机
        /// </summary>
        [XmlElement("contact_kp_tel")]
        public string ContactKpTel { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 内景图,按照列表顺序展示
        /// </summary>
        [XmlArray("detail_images")]
        [XmlArrayItem("string")]
        public List<string> DetailImages { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 图片对应的图片Id
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 主店名
        /// </summary>
        [XmlElement("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 当前操作人id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 异步结果通知地址
        /// </summary>
        [XmlElement("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

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
        /// 外部流水号
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
