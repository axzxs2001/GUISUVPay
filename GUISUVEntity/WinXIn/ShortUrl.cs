using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin
{
    /// <summary>
    /// 转换短连接ck
    /// </summary>
    public class ShortUrl
    {
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
        /// URL链接   必填  521
        /// </summary>
        public string Long_Url
        {
            get;
            set;
        }
        public string Device_Info
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
        /// 签名类型
        /// </summary>
        public string Sign_Type
        {
            get;
            set;
        }
    }
}
