using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 关闭订单Back
    /// </summary>
    public class CloseOrderBack
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
        /// 业务结果   必填16
        /// </summary>
        public string Result_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 业务结果描述   必填  32
        /// </summary>
        public string Result_Msg
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码     32
        /// </summary>
        public string Err_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码描述    128
        /// </summary>
        public string Err_Code_Des
        {
            get;
            set;
        }    
    }
}
