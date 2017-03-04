using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionMissionCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertCommissionMissionCreateModel : AopObject
    {
        /// <summary>
        /// PERCENTAGE_CLAUSE：百分比结算条款  QUOTA_CLAUSE：定额结算条款  MISSION_CLAIM_CLAUSE：专属认领人条款
        /// </summary>
        [XmlArray("commission_clause")]
        [XmlArrayItem("kb_advert_commission_clause")]
        public List<KbAdvertCommissionClause> CommissionClause { get; set; }

        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("identify")]
        public string Identify { get; set; }

        /// <summary>
        /// 主键类型  activity_id：运营活动ID  voucher：商品ID
        /// </summary>
        [XmlElement("identify_type")]
        public string IdentifyType { get; set; }

        /// <summary>
        /// 分佣任务名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 操作人id，必须和operator_type配对出现，不填时默认是商户
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人类型,有以下值可填：MERCHANT（外部商户），默认不需要填这个字段，默认为MERCHANT
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
