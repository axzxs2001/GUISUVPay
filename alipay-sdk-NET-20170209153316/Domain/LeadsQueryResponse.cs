using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LeadsQueryResponse Data Structure.
    /// </summary>
    [Serializable]
    public class LeadsQueryResponse : AopObject
    {
        /// <summary>
        /// 联系地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店授权函,营业执照与签约账号主体不一致时需要
        /// </summary>
        [XmlElement("auth_letter")]
        public string AuthLetter { get; set; }

        /// <summary>
        /// 授权函url
        /// </summary>
        [XmlElement("auth_letter_url")]
        public string AuthLetterUrl { get; set; }

        /// <summary>
        /// 人均消费价格
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 门店是否有包厢，T表示有，F表示没有
        /// </summary>
        [XmlElement("box")]
        public string Box { get; set; }

        /// <summary>
        /// 分店名
        /// </summary>
        [XmlElement("branch_shop_name")]
        public string BranchShopName { get; set; }

        /// <summary>
        /// 品牌LOGO; 图片ID。
        /// </summary>
        [XmlElement("brand_logo")]
        public string BrandLogo { get; set; }

        /// <summary>
        /// logo图片url
        /// </summary>
        [XmlElement("brand_logo_url")]
        public string BrandLogoUrl { get; set; }

        /// <summary>
        /// 品牌名，不填写则默认为“其它品牌”
        /// </summary>
        [XmlElement("brand_name")]
        public string BrandName { get; set; }

        /// <summary>
        /// 经营许可证
        /// </summary>
        [XmlElement("business_certificate")]
        public string BusinessCertificate { get; set; }

        /// <summary>
        /// 经营许可证有效期，格式：2020-03-20，只有餐饮类目需要
        /// </summary>
        [XmlElement("business_certificate_expires")]
        public string BusinessCertificateExpires { get; set; }

        /// <summary>
        /// 许可证图片url
        /// </summary>
        [XmlElement("business_certificate_url")]
        public string BusinessCertificateUrl { get; set; }

        /// <summary>
        /// 营业时间，支持分段营业时间，以英文逗号分隔
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 最细的类目编号
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 城市编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// leads认领时间
        /// </summary>
        [XmlElement("claim_time")]
        public string ClaimTime { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [XmlElement("contact_number")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// leads创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 门店内景图。  建议上传3-10张，尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlArray("detail_images")]
        [XmlArrayItem("string")]
        public List<string> DetailImages { get; set; }

        /// <summary>
        /// 门店内景图名称列表
        /// </summary>
        [XmlArray("detail_images_name")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesName { get; set; }

        /// <summary>
        /// 门店内景图URL列表
        /// </summary>
        [XmlArray("detail_images_url")]
        [XmlArrayItem("string")]
        public List<string> DetailImagesUrl { get; set; }

        /// <summary>
        /// 区县编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 扩展属性，JSON格式：keyMerchant-是否重点商户（T/F）
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 机具号，多个之间以英文逗号分隔
        /// </summary>
        [XmlElement("implement_id")]
        public string ImplementId { get; set; }

        /// <summary>
        /// 是否已补全信息，如果为T，表示leads已经补全信息，可以开店
        /// </summary>
        [XmlElement("is_complete")]
        public string IsComplete { get; set; }

        /// <summary>
        /// 是否隐藏：T-是，F-否。
        /// </summary>
        [XmlElement("is_hidden")]
        public string IsHidden { get; set; }

        /// <summary>
        /// 是否在其他平台开店，T表示有开店，F表示未开店，用于证明其开店资质，如无营业执照必须有在其他平台的开店资质才能入住口碑平台，其他平台主要包括美团、点评。
        /// </summary>
        [XmlElement("is_operating_online")]
        public string IsOperatingOnline { get; set; }

        /// <summary>
        /// 是否系统导入leads：T-是，F-否。
        /// </summary>
        [XmlElement("is_system_import")]
        public string IsSystemImport { get; set; }

        /// <summary>
        /// 纬度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("latitude")]
        public long Latitude { get; set; }

        /// <summary>
        /// 支付宝leads ID，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [XmlElement("leads_id")]
        public string LeadsId { get; set; }

        /// <summary>
        /// PUBLIC：公海 PRIVATE：私海
        /// </summary>
        [XmlElement("leads_range")]
        public string LeadsRange { get; set; }

        /// <summary>
        /// 门店营业执照图片
        /// </summary>
        [XmlElement("licence")]
        public string Licence { get; set; }

        /// <summary>
        /// 门店营业执照编号
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
        /// 证照图片url
        /// </summary>
        [XmlElement("licence_url")]
        public string LicenceUrl { get; set; }

        /// <summary>
        /// 经度，注：高德坐标系，需要服务商引导用户校准经纬度
        /// </summary>
        [XmlElement("longitude")]
        public long Longitude { get; set; }

        /// <summary>
        /// 门店首图。  建议尺寸在2000px＊1500px以上，格式为bmp、png、jpg、gif，不超过10M。
        /// </summary>
        [XmlElement("main_image")]
        public string MainImage { get; set; }

        /// <summary>
        /// 门店首图名称
        /// </summary>
        [XmlElement("main_image_name")]
        public string MainImageName { get; set; }

        /// <summary>
        /// 门店首图URL
        /// </summary>
        [XmlElement("main_image_url")]
        public string MainImageUrl { get; set; }

        /// <summary>
        /// 主门店名
        /// </summary>
        [XmlElement("main_shop_name")]
        public string MainShopName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否有无烟区，T表示有无烟区，F表示没有无烟区
        /// </summary>
        [XmlElement("no_smoking")]
        public string NoSmoking { get; set; }

        /// <summary>
        /// 其他平台开店竞对图片url，多个url使用英文逗号隔开,isv迁移到新接口使用此字段，与is_operating_online=T配套使用。online_image升级到version=2.0版本后将废弃，使用online_url替代。
        /// </summary>
        [XmlElement("online_url")]
        public string OnlineUrl { get; set; }

        /// <summary>
        /// 操作用户的支付账号id
        /// </summary>
        [XmlElement("op_id")]
        public string OpId { get; set; }

        /// <summary>
        /// 支付宝内部使用，外部商户不需要填写此字段。其他资质
        /// </summary>
        [XmlElement("other_authorization")]
        public string OtherAuthorization { get; set; }

        /// <summary>
        /// 其他资质url列表，逗号分隔
        /// </summary>
        [XmlElement("other_authorization_url")]
        public string OtherAuthorizationUrl { get; set; }

        /// <summary>
        /// 其他联系方式
        /// </summary>
        [XmlElement("other_contact_info")]
        public string OtherContactInfo { get; set; }

        /// <summary>
        /// 门店是否支持停车，T表示支持，F表示不支持
        /// </summary>
        [XmlElement("parking")]
        public string Parking { get; set; }

        /// <summary>
        /// 付款方式：code_scanned_pay：付款码  online_pay：在线买单
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 省份编码。  国标码，详见国家统计局数据。
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 请求ID，标识本次创建请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// leads状态。  INIT：未认领，CLAIMED：已认领，CONFIRMING：待商户确认，RELATED：已关联商户，OPENING：开店中，OPENED：已开店。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 外部门店编号；
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
