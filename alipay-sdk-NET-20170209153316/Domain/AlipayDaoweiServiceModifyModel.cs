using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDaoweiServiceModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiServiceModifyModel : AopObject
    {
        /// <summary>
        /// 服务保障描述
        /// </summary>
        [XmlArray("assurance_desc")]
        [XmlArrayItem("assurance_info")]
        public List<AssuranceInfo> AssuranceDesc { get; set; }

        /// <summary>
        /// 注意事项描述，支持图文形式，text为文本，分成不同的json表示换行，img为图片url，只支持https，图片大小限制60K以下。请勿发布涉及黄赌毒以及其他违反国家法律法规的图片,否则会导致服务下架，情节严重者会被到位强制解约
        /// </summary>
        [XmlArray("attention")]
        [XmlArrayItem("common_desc_info")]
        public List<CommonDescInfo> Attention { get; set; }

        /// <summary>
        /// 服务所属的到位类目id,可发邮件到lei.mao@antfin.com,联系支付宝获取开通类目ID列表.支付宝在收到邮件后三个工作日内回复
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 服务城市行政编码，请参考高德标准。如果为空，表示能服务全国。城市编码请从http://lbs.amap.com/api/javascript-api/download/下载最新全国标准城市码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 服务内容描述，支持图文形式，text为文本，分成不同的json表示换行，img为图片url，只支持https，图片大小限制60K以下。请勿发布涉及黄赌毒以及其他违反国家法律法规的图片,否则会导致服务下架，情节严重者会被到位强制解约
        /// </summary>
        [XmlArray("desc")]
        [XmlArrayItem("common_desc_info")]
        public List<CommonDescInfo> Desc { get; set; }

        /// <summary>
        /// 服务的区县范围，请参考高德标准。如果为空，表示能服务整个城市。城市编码请从http://lbs.amap.com/api/javascript-api/download/下载最新全国标准城市码
        /// </summary>
        [XmlArray("district_code_list")]
        [XmlArrayItem("string")]
        public List<string> DistrictCodeList { get; set; }

        /// <summary>
        /// 商品封面图片url列表,单张图片大小不超过60KB，支持jpg、png格式,协议必须是HTTPS，数量小于等于10张。请勿发布涉及黄赌毒以及其他违反国家法律法规的图片,否则会导致服务下架，情节严重者会被到位强制解约
        /// </summary>
        [XmlArray("image_urls")]
        [XmlArrayItem("string")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 服务所在坐标的纬度（高德坐标系），服务者模式必传。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 服务所在位置的经度（高德坐标系），如果是服务者模式必传。高德经纬度查询：http://lbs.amap.com/console/show/picker
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 服务模式， 可选值： SP（服务者模式）、DISPATCH(派单模式)
        /// </summary>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 外部服务id,商家自己维护的唯一标识,用于确定商家的某个服务.仅支持数字,字母和下划线
        /// </summary>
        [XmlElement("out_service_id")]
        public string OutServiceId { get; set; }

        /// <summary>
        /// 外部的服务者id：由商家自己维护的服务者唯一标识,服务者模式必填.仅支持数字,字母和下划线
        /// </summary>
        [XmlElement("out_sp_id")]
        public string OutSpId { get; set; }

        /// <summary>
        /// 服务报价描述，支持图文形式，text为文本，分成不同的json表示换行，img为图片url，只支持https，图片大小限制60K以下。请勿发布涉及黄赌毒以及其他违反国家法律法规的图片,否则会导致服务下架，情节严重者会被到位强制解约
        /// </summary>
        [XmlArray("price_desc")]
        [XmlArrayItem("common_desc_info")]
        public List<CommonDescInfo> PriceDesc { get; set; }

        /// <summary>
        /// 价格维度类型，可选值:string；json，不填默认string，表示unit_price的类型为是一维价格，如果是json默认是多维价格
        /// </summary>
        [XmlElement("price_dim_type")]
        public string PriceDimType { get; set; }

        /// <summary>
        /// 服务流程描述，支持图文形式，text为文本，分成不同的json表示换行，img为图片url，只支持https，图片大小限制60K以下。请勿发布涉及黄赌毒以及其他违反国家法律法规的图片,否则会导致服务下架，情节严重者会被到位强制解约
        /// </summary>
        [XmlArray("process_desc")]
        [XmlArrayItem("common_desc_info")]
        public List<CommonDescInfo> ProcessDesc { get; set; }

        /// <summary>
        /// 可用数量，不填写表示不限量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务范围描述，可以用于描述服务的商圈范围信息
        /// </summary>
        [XmlElement("service_range")]
        public string ServiceRange { get; set; }

        /// <summary>
        /// 服务状态，支持以下状态：ON(上架);OFF(下架);DELETE(删除).ON表示上架服务,在创建和修改服务时,必须设置为ON,调用接口成功后服务会在一分钟内上架;OFF表示下架服务,此操作不会修改服务内容,服务下架后用户将无法再到位中看到该服务，后续可以通过设置状t态为ON重新上架服务;DELETE表示删除该服务,此操作不可恢复
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 服务上提示给消费者的标签，每个标签最多10个字符，英文逗号间隔，最多支持5个标签
        /// </summary>
        [XmlElement("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// 服务类型，可选值：ONLINE(线上服务)、OFFLINE(线下服务)
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 服务价格单位，可选值：PER_TIME（每次）；PER_GE（每个）；PER_FU（每幅）；PER_PIECE（每份）；PER_DAN（每单）；PER_HOUR（每小时）
        /// </summary>
        [XmlElement("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 单价，单位为元，根据price_dim_type的值决定如果是一维价格直接使用字符串，比如："30.5"，如果是多维，比如同一个属性不同地区价格不同的情况，比如  {    "-1": "30", //表示默认价   "110100": "60"  }  "110100"为北京城市码，参考高德标准，该配置表示北京地区价格60元，其他地区价格30元
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }
    }
}
