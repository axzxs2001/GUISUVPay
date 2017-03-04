using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUISUVPayEntity.WeiXin.ShaoMa
{
    /// <summary>
    /// 统一下单
    /// </summary>
    public class UnifiedOrder
    {     
      
        /// <summary>
        /// 商品描述  必填 128
        /// </summary>
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// 商品详情     6000
        /// </summary>
        public string Detail
        {
            get;
            set;
        }
        /// <summary>
        /// 附加数据     127
        /// </summary>
        public string Attach
        {
            get;
            set;
        }
        /// <summary>
        /// 商户订单号  必填  32   
        /// </summary>
        public string Out_Trade_No
        {
            get;
            set;
        }
        /// <summary>
        /// 标价币种    16
        /// </summary>
        public string Fee_Type
        {
            get;
            set;
        }
        /// <summary>
        /// 标价金额(单位分)     必填  88
        /// </summary>
        public int Total_Fee
        {
            get;
            set;
        }
       
        /// <summary>
        /// 交易起始时间     14 
        /// </summary>
        public string Time_Start
        {
            get;
            set;
        }
        /// <summary>
        /// 交易结束时间     14
        /// </summary>
        public string Time_Expire
        {
            get;
            set;
        }
        /// <summary>
        /// 商品标记   32
        /// </summary>
        public string Goods_Tag
        {
            get;
            set;
        }
       
       
        /// <summary>
        /// 商品ID     32
        /// </summary>
        public string Product_ID
        {
            get;
            set;
        }  
    }

}
