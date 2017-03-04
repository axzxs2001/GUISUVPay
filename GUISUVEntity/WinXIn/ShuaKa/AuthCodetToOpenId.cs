using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShuaKa
{
    /// <summary>
    /// 授权码查询
    /// </summary>
    public class AuthCodetToOpenId
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
        /// 授权码
        /// </summary>
        public string Auth_Code
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
    }
}
