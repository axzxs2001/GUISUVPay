using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataCustomtagSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataCustomtagSaveModel : AopObject
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
        /// 自定义标签名称，该属性不支持修改。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签CODE-为空则为创建规则，否则更新规则
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }
    }
}
