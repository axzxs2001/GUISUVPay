using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUISUVPay.Model
{
    /// <summary>
    /// 重写属性处理类
    /// </summary>
    class LowerPropertyContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// 重密属性全部改成小写
        /// </summary>
        /// <param name="type"></param>
        /// <param name="memberSerialization"></param>
        /// <returns></returns>
        protected override IList<JsonProperty> CreateProperties(Type type, Newtonsoft.Json.MemberSerialization memberSerialization)
        {
            var properties = base.CreateProperties(type, memberSerialization);
            foreach (var pro in properties)
            {
                pro.PropertyName = pro.PropertyName.ToLower();
            }
            return properties;
        }
    }
}
