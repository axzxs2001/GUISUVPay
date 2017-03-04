using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zhifubao.monitor.heartbeat.syn
{
    /// <summary>
    /// 当面付交易保障返回实体类
    /// </summary>
    public class SynBack
    {
        /// <summary>
        /// 商户订单号 必填 32
        /// </summary>
        public string OTN
        {
            get;
            set;
        }
        /// <summary>
        /// 交易耗时 必填 8
        /// </summary>
        public string TC
        {
            get;
            set;
        }
        /// <summary>
        /// 交易状态  必填 1
        /// </summary>
        public string STAT
        {
            get;
            set;
        }
    }
}
