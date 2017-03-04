using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShuaKa
{
    /// <summary>
    /// 交易保障
    /// </summary>
    public class Report
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
        /// 设备号
        /// </summary>
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
        /// 接口URL      必填 127
        /// </summary>
        public string Interface_Url
        {
            get;
            set;
        }
        /// <summary>
        /// 访问接口IP    必填 16
        /// </summary>
        public string User_Ip
        {
            get;
            set;
        }
        /// <summary>
        /// 上报数据包    必填 1024
        /// </summary>
        public string Trades
        {
            get;
            set;
        }
    }
}
