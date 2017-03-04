using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShuaKa
{
    /// <summary>
    /// 关闭订单Back
    /// </summary>
    public class SKCloseOrderBack:CloseOrderBack
    {
        /// <summary>
        /// 是否重调 是否需要继续调用撤销，Y-需要，N-不需要
        /// </summary>
        public string Recall
        { get; set; }
    }
}
