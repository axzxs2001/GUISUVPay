using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenPublicMenuCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMenuCreateModel : AopObject
    {
        /// <summary>
        /// 一级菜单数组，个数应为1~4个
        /// </summary>
        [XmlArray("button")]
        [XmlArrayItem("button_object")]
        public List<ButtonObject> Button { get; set; }
    }
}
