using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhifubao.monitor.heartbeat.syn
{
    /// <summary>
    /// 当面付交易保障
    /// </summary>
    public class Syn
    {
        /// <summary>
        /// 发送心跳的设备所依赖的支付宝产品 必填 5
        /// </summary>
        public string Product
        {
            get;
            set;
        }
        /// <summary>
        /// 发送心跳的设备类型  必填  10
        /// </summary>
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// 发送心跳的设备ID 必填 32
        /// </summary>
        public string Equipment_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 心跳发生时间 必填 19
        /// </summary>
        public string Time
        {
            get;
            set;
        }
        /// <summary>
        /// 门店ID 必填 32
        /// </summary>
        public string Store_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 网络类型 必填 4
        /// </summary>
        public string Network_Type
        {
            get;
            set;
        }
        /// <summary>
        ///  系统商的编号 16
        /// </summary>
        public string Sys_Service_Provider_Id
        {
            get;
            set;
        }
        /// <summary>
        /// Mac地址  64
        /// </summary>
        public string Mac
        {
            get;
            set;
        }
        /// <summary>
        /// 交易性能信息 必填 256
        /// </summary>
        public string Trade_Info
        {
            get;
            set;
        }
        /// <summary>
        /// 异常信息  128
        /// </summary>
        public string Exception_Info
        {
            get;
            set;
        }
        /// <summary>
        /// 扩展信息 256
        /// </summary>
        public string Extend_Info
        {
            get;
            set;
        }
    }
}
