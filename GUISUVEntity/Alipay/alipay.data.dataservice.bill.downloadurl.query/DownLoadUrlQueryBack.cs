using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.Alipay
{
    public class DownLoadUrlQueryBack
    {
        /// <summary>
        /// 网关返回码,详见文档  必填 -
        /// </summary>
        public string Code
        {
            get;
            set;
        }
        /// <summary>
        /// 网关返回码描述,详见文档 必填 -
        /// </summary>
        public string Msg
        {
            get;
            set;
        }
        /// <summary>
        /// 业务返回码,详见文档  -
        /// </summary>
        public string Sub_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 业务返回码描述,详见文档 -
        /// </summary>
        public string Sub_Msg
        {
            get;
            set;
        }   
        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。 必填 2048 
        /// </summary>
        public string Bill_Download_Url
        {
            get;
            set;
        }
    }
}
