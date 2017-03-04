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
        /// 签名类型
        /// </summary>
        public string Sign_Type
        {
            get;
            set;
        }
        /// <summary> 
        /// 接口URL    必填  127
        /// </summary>
        public string Interface_Url
        {
            get;
            set;
        }
        /// <summary>
        /// 接口耗时   必填  1000
        /// </summary>
        public int Execute_Time
        {
            get;
            set;
        }
        /// <summary>
        /// 返回状态码   AUCCESS
        /// </summary>
        public string Return_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 返回信息   128
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
        /// <summary>
        /// 错误代码   32
        /// </summary>
        public string Err_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 错误代码描述   128
        /// </summary>
        public string Err_Code_Des
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号   32
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 访问接口IP  必填  16
        /// </summary>
        public string User_Ip
        {
            get;
            set;
        }
        /// <summary>
        /// 商户上报时间   14
        /// </summary>
        public string Time
        {

            get;
            set;
        }
    }
}
