using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEcoEduKtSchoolinfoModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtSchoolinfoModifyModel : AopObject
    {
        /// <summary>
        /// 市的国家编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 区县的国家编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 区县名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 商家名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 商家编码，ISV_NO
        /// </summary>
        [XmlElement("isv_no")]
        public string IsvNo { get; set; }

        /// <summary>
        /// 此链接是为了保持教育缴费平台与ISV  商户支付状态一致性。用户支付成功后，会异步回调此链接，回调时，会带入支付的相关参数，ISV商户可以根据返回的参数更新账单状态。支付宝异步通知说明
        /// </summary>
        [XmlElement("isv_notify_url")]
        public string IsvNotifyUrl { get; set; }

        /// <summary>
        /// Isv支付宝pid，商家在支付宝的唯一标识
        /// </summary>
        [XmlElement("isv_phone")]
        public string IsvPhone { get; set; }

        /// <summary>
        /// Isv支付宝pid，用于支付返佣
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 省的国家编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 省名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 学校的图像，一般为学校的标识，该字段为图片的链接地址，只支持png或jpg图片格式，图片高度为108，宽度为108 ，不大于20k
        /// </summary>
        [XmlElement("school_icon")]
        public string SchoolIcon { get; set; }

        /// <summary>
        /// 如果学校图像数据填写，则此字段不能为空。目前只支持png和jpg两种格式
        /// </summary>
        [XmlElement("school_icon_type")]
        public string SchoolIconType { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [XmlElement("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校支付宝pid，用于授权
        /// </summary>
        [XmlElement("school_pid")]
        public string SchoolPid { get; set; }

        /// <summary>
        /// 学校的国家标准编码
        /// </summary>
        [XmlElement("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// 学校的类型：托幼小初高。1、托, 2、幼,  3、小,  4、初,  5、高。如果学校兼有多种属性，可以写为：初高中为45 ， 小初为34
        /// </summary>
        [XmlElement("school_type")]
        public string SchoolType { get; set; }
    }
}
