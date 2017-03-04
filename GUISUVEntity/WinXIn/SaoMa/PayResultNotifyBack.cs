using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShaoMa
{
    /// <summary>
    /// 支付结果通知Back
    /// </summary>
    public class PayResultNotifyBack
    {
        /// <summary>
        /// 返回状态码,success表示成功，fail表示失败
        /// </summary>
        public string Return_Code
        {
            get;
            set;
        }
        /// <summary>
        /// 返回信息，ok表示成功，失败说明具体原因
        /// </summary>
        public string Return_Msg
        {
            get;
            set;
        }
    }
}
