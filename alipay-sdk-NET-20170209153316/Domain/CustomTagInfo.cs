using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CustomTagInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CustomTagInfo : AopObject
    {
        /// <summary>
        /// 列表中的每一个DataEnumValue表示自定义标签的一个枚举值，例如：定义标签为高富帅，则高富帅有高，中，低三个枚举值，本期只支持枚举值为1个的场景，并且枚举值的value固定为1，目前支持的数据标签字典参见<a href="http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/reportAPIrule.xls">附件</a>
        /// </summary>
        [XmlArray("enum_values")]
        [XmlArrayItem("data_enum_value")]
        public List<DataEnumValue> EnumValues { get; set; }

        /// <summary>
        /// 对自定义标签的描述
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签code
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
