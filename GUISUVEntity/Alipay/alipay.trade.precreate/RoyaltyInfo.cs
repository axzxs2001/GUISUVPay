using System.Collections.Generic;

namespace SUISUVPayEntity.Alipay
{
    public class RoyaltyInfo
    {
        /// <summary>
        /// 分账类型 卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。 可选 150 
        /// </summary>
        public string Royalty_Type
        {
            get;
            set;
        }

        public List<RoyaltyDetailInfos> Royalty_Detail_Infos
        {
            get;set;
        }
    }
}