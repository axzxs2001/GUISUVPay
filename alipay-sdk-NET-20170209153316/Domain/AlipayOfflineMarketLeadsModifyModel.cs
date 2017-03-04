using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketLeadsModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketLeadsModifyModel : AopObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店授权函,营业执照与签约账号主体不一致时需要
        /// </summary>
        [XmlElement("auth_letter")]
        public string AuthLetter { get; set; }

        /// <summary>
        /// 人均消费价格，最少1元，最大不超过99999元，请按实际情况填写；单位元，不需填写单位；
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 门店是否有包厢，T表示有，F表示没有，不传在客户端不作展示
        /// </summary>
        [XmlElement("box")]
        public string Box { get; set; }

        /// <summary>
        /// 分店名称
        /// </summary>
        [XmlElement("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌LOGO; 图片ID。
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 经营许可证，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate")]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 经营许可证有效期，格式：2020-03-20，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate_expires")]
        public string BusinessCertificateExpires { get; set; }

        /// <summary>
        /// 营业时间，支持分段营业时间，以英文逗号分隔
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

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
        /// 营业执照上的公司名称，如果修改为空，传入:"#EMPTY#",传入空，不修改
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
        /// 联系电话
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 内景图
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
        /// 机具号，多个之间以英文逗号分隔
        /// </summary>
        [XmlElement("implement_id")]
        public string ImplementId { get; set; }

        /// <summary>
        /// 是否补全信息，如果传T，表示当前请求是补全信息，只有补全了信息的leads，才允许开店
        /// </summary>
        [XmlElement("is_complete")]
        public string IsComplete { get; set; }

        /// <summary>
        /// 是否在其他平台开店，T表示有开店，F表示未开店，用于证明其开店资质，如无营业执照必须有在其他平台的开店资质才能入住口碑平台，其他平台主要包括美团、点评。
        /// </summary>
        [XmlElement("is_operating_online")]
        public string IsOperatingOnline { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 修改的leadsId
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// 门店营业执照图片，营业执照信息与is_operating_online至少填一项
        /// </summary>
        [XmlElement("licence")]
        public string Licence { get; set; }

        /// <summary>
        /// 门店营业执照编号，营业执照信息与is_operating_online至少填一项
        /// </summary>
        [XmlElement("licence_code")]
        public string LicenceCode { get; set; }

        /// <summary>
        /// 营业执照过期时间
        /// </summary>
        [XmlElement("licence_expires")]
        public string LicenceExpires { get; set; }

        /// <summary>
        /// 门店营业执照名称
        /// </summary>
        [XmlElement("licence_name")]
        public string LicenceName { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 门店首图
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
        /// 是否有无烟区，T表示有无烟区，F表示没有无烟区，不传在客户端不展示
        /// </summary>
        [XmlElement("no_smoking")]
        public string NoSmoking { get; set; }

        /// <summary>
        /// 其他平台开店竞对图片url，多个url使用英文逗号隔开,isv迁移到新接口使用此字段，与is_operating_online=T配套使用。online_image升级到version=2.0版本后将废弃，使用online_url替代。
        /// </summary>
        [XmlElement("online_url")]
        public string OnlineUrl { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 异步结果通知
        /// </summary>
        [XmlElement("operate_notify_url")]
        public string OperateNotifyUrl { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。其他资质
        /// </summary>
        [XmlElement("other_authorization")]
        public string OtherAuthorization { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 门店是否支持停车，T表示支持，F表示不支持，不传在客户端不作展示
        /// </summary>
        [XmlElement("parking")]
        public string Parking { get; set; }

        /// <summary>
        /// 付款方式：code_scanned_pay：付款码  online_pay：在线买单
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

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

        /// <summary>
        /// 外部门店编号；最长54位字符，该编号将作为收单接口的入参， 请开发者自行确保其唯一性
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店其他的服务，门店与用户线下兑现
        /// </summary>
        [XmlElement("value_added")]
        public string ValueAdded { get; set; }

        /// <summary>
        /// 门店是否支持WIFI，T表示支持，F表示不支持，不传在客户端不作展示
        /// </summary>
        [XmlElement("wifi")]
        public string Wifi { get; set; }
    }
}
