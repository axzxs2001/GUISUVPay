using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 转换短连接
    /// </summary>
    public class ShortUrlBack
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
        /// 公众账号ID
        /// </summary>
        public string Appid
        {
            get;
            set;
        }
        /// <summary>
        /// 商户号
        /// </summary>
        public string Mch_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 随机字符串
        /// </summary>
        public string Nonce_Str
        {
            get;
            set;
        }
        /// <summary>
        /// 签名
        /// </summary>
        public string Sign
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
        /// URL链接   必填  64
        /// </summary>
        public string Short_Url 
        {
            get;
            set;
        }
    }
}
