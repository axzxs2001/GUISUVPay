using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiMarketingDataDishdiagnoseBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingDataDishdiagnoseBatchqueryModel : AopObject
    {
        /// <summary>
        /// 查询菜品类型：1- 招牌菜品；2-中游菜品；3-潜力菜品；4-疑问菜品；5-其他菜品，具体看类型范文接口  2- 如果要查询所有的则传入999。具体的值可以通过koubei.marketing.data.dishdiagnosetype.batchquery来查询，同时会返回类型与说明
        /// </summary>
        [XmlElement("item_diagnose_type")]
        public string ItemDiagnoseType { get; set; }

        /// <summary>
        /// 从第一页开始，默认值1
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，默认值50，同时page_size*page_no最多条数是300条，查询请注意。超过后不会再返回数据。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询数据时间,最新数据是昨天的。T-1的数据，最大保留30天,格式：YYYYMMDD。比如20170103
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }
    }
}
