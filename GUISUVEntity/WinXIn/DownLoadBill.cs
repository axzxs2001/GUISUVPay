using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 下载对账单
    /// </summary>
    public class DownLoadBill
    {       
        /// <summary>
        /// 对账单日期   必填  8
        /// </summary>
        public string Bill_Date
        {
            get;
            set;
        }
        /// <summary>
        /// 账单类型   必填  8
        /// </summary>
        public string Bill_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 压缩账单    8
        /// </summary>
        public string Tar_Type
        {
            get;
            set;
        } = "";
    }
}
