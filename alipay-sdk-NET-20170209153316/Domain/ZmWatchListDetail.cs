using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmWatchListDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ZmWatchListDetail : AopObject
    {
        /// <summary>
        /// 行业编码，例如：  AA 金融（信贷类）；  AB 公检法 ；  AC 金融（支付类）；  AD 租车行业；  AE 酒店行业；  AF 电商行业；  AG 租房行业；  AH 运营商；  AI 保险行业；  AJ 公共事业。  该列表动态更新，更新前芝麻将进行通知。
        /// </summary>
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 风险编码，编码由芝麻进行维护和升级，会存在新增编码的可能，更新前芝麻会进行通知。
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行业关注名单记录扩展信息
        /// </summary>
        [XmlArray("extend_info")]
        [XmlArrayItem("zm_watch_list_extend_info")]
        public List<ZmWatchListExtendInfo> ExtendInfo { get; set; }

        /// <summary>
        /// 数据更新时间
        /// </summary>
        [XmlElement("refresh_time")]
        public string RefreshTime { get; set; }

        /// <summary>
        /// 对于借款贷款信用消费等，该字段标识是否结清。true，已经结清；false，未结清。
        /// </summary>
        [XmlElement("settlement")]
        public bool Settlement { get; set; }

        /// <summary>
        /// 当用户进行异议处理，并核查完毕之后，仍有异议时，给出的声明
        /// </summary>
        [XmlElement("statement")]
        public string Statement { get; set; }

        /// <summary>
        /// 用户本人对该条负面记录有异议时，表示该异议处理流程的状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行业名单风险类型，编码由芝麻进行维护和升级，会存在新增编码的可能，更新前芝麻将会进行通知。
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
