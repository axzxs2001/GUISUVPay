namespace SUISUVPayEntity.Alipay
{ 
    public class GoodsDetail
    {
        /// <summary>
        ///  商品的编号  必填 32 
        /// </summary>
        public string Goods_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 支付宝定义的统一商品编号  可选 32 
        /// </summary>
        public string Alipay_Goods_Id
        {
            get;
            set;
        }
        /// <summary>
        /// 商品名称  必填 256 
        /// </summary>
        public string Goods_Name
        {
            get;
            set;
        }
        /// <summary>
        /// 商品数量  必填 10 
        /// </summary>
        public int Quantity
        {
            get;
            set;
        }
        /// <summary>
        /// 商品单价，单位为元  必填  9 
        /// </summary>
        public decimal Price
        {
            get;
            set;
        }
        /// <summary>
        /// 商品类目  可选 24 
        /// </summary>
        public string Goods_Category
        {
            get;
            set;
        }
        /// <summary>
        /// 商品描述信息  可选 1000 
        /// </summary>
        public string Body
        {
            get;
            set;
        }
        /// <summary>
        /// 商品的展示地址 可选 400 
        /// </summary>
        public string Show_Url
        {
            get;
            set;
        }
    }
}