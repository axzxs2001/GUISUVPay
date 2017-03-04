using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 下载对账单Back
    /// </summary>
    public class DownLoadBillBack
    {
        /// <summary>
        /// 返回状态码,成功时为null
        /// </summary>
        public string Return_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 返回信息,成功时为null
        /// </summary>
        public string Return_Msg
        {
            get;
            set;
        }

        /// <summary>
        /// 如果成功返回正确数据
        /// </summary>
        public string BackData
        {
            get;
            set;
        }
    }
}
