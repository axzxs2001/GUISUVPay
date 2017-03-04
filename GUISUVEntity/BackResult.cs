using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SUISUVPayEntity
{
    /// <summary>
    /// 交易返回结果类型
    /// </summary>
    /// <typeparam name="T">返回具体实体类</typeparam>
    public class BackResult<T>
    {
        /// <summary>
        /// 返回结果，true为成功，false为失败
        /// </summary>
        public bool Result
        {
            get; set;
        }
        /// <summary>
        /// 失败时的原因
        /// </summary>
        public string Message
        {
            get; set;
        }
        /// <summary>
        /// 返回的实体类
        /// </summary>
        public T Entity
        { get; set; }
    }
}
