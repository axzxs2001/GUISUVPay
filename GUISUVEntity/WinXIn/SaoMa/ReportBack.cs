using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShaoMa
{
    /// <summary>
    /// 交易保障
    /// </summary>
    public class ReportBack
    {
        /// <summary>
        /// 返回状态码
        /// </summary>
        public string Return_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 返回信息
        /// </summary>
        public string Return_Msg
        {
            get;
            set;
        }
        /// <summary>
        /// 业务结果   必填  16
        /// </summary>
        public string Result_Code
        {
            get;
            set;
        }
    }
}
