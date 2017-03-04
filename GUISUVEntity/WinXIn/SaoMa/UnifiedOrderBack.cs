using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShaoMa
{
    /// <summary>
    /// 统一下单Back
    /// </summary>
    public class UnifiedOrderBack
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
        /// 业务结果
        /// </summary>
        public string Result_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码
        /// </summary>
        public string Err_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码描述
        /// </summary>
        public string Err_Code_Des
        {
            get;
            set;
        }
        /// <summary>
        /// 交易类型
        /// </summary>
        public string Rrade_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 预支付交易会话标识
        /// </summary>
        public string Prepay_ID
        {
            get;
            set;
        }
        /// <summary>
        /// 二维码链接
        /// </summary>
        public string Code_Url
        {
            get;
            set;
        }
    }
}
