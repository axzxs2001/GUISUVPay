using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ButtonObject Data Structure.
    /// </summary>
    [Serializable]
    public class ButtonObject : AopObject
    {
        /// <summary>
        /// 当actionType为link时，该参数为详细链接；  当actionType为out时，该参数为用户自定义参数；  当actionType为tel时，该参数为电话号码。  该参数最长255个字符，不允许冒号等特殊字符
        /// </summary>
        [XmlElement("action_param")]
        public string ActionParam { get; set; }

        /// <summary>
        /// 菜单类型：  out——事件型菜单；  link——链接型菜单；  tel——点击拨打电话
        /// </summary>
        [XmlElement("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 菜单标题，一级菜单不超过4个汉字，子菜单不超过12个汉字
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 二级菜单数组，个数应为1~5个
        /// </summary>
        [XmlArray("sub_button")]
        [XmlArrayItem("sub_button")]
        public List<SubButton> SubButton { get; set; }
    }
}
