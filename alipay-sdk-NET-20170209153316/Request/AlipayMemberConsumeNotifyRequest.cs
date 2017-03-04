using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.member.consume.notify
    /// </summary>
    public class AlipayMemberConsumeNotifyRequest : IAopRequest<AlipayMemberConsumeNotifyResponse>
    {
        /// <summary>
        /// 实付金额
        /// </summary>
        public string ActPayAmount { get; set; }

        /// <summary>
        /// 会员卡卡号
        /// </summary>
        public string BizCardNo { get; set; }

        /// <summary>
        /// point:整数  balance:金额格式  level:String
        /// </summary>
        public string CardInfo { get; set; }

        /// <summary>
        /// 商户给会员开设的卡号，最大长度不超过32
        /// </summary>
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 获取权益列表，是指由于发生当前交易，而使用户最终获取到的特权列表信息，  实际消耗的权益，这是个json字段  &#61550; 卡面额权益说明（元为单位）  benefitType：PRE_FUND（卡面额）  amount：80.00  &#61550; 券权益说明（张数为单位）  benefitType：COUPON  count：5  description：2元抵用券  amount：10.00
        /// </summary>
        public string GainBenefitList { get; set; }

        /// <summary>
        /// 备注信息，现有直接填写门店信息
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 门店编号
        /// </summary>
        public string ShopCode { get; set; }

        /// <summary>
        /// ALIPAY：支付宝电子卡  ENTITY：实体卡  OTHER：其他
        /// </summary>
        public string SwipeCertType { get; set; }

        /// <summary>
        /// 交易金额：本次交易的实际总金额（可认为标价金额）
        /// </summary>
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易名称
        /// </summary>
        public string TradeName { get; set; }

        /// <summary>
        /// 商户端对当前消费交易的单据号
        /// </summary>
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易事件
        /// </summary>
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易类型  消费：TRADE  充值：DEPOSIT
        /// </summary>
        public string TradeType { get; set; }

        /// <summary>
        /// 实际消耗的权益，这是个json字段  &#61550; 卡面额权益说明（元为单位）  benefitType：PRE_FUND（卡面额）  amount：80.00    &#61550; 折扣权益说明（元为单位）  benefitType：DISCOUNT  amount：10.00  description：折扣10元    &#61550; 券权益说明（张数为单位）  benefitType：COUPON  count：5  description：2元抵用券
        /// </summary>
        public string UseBenefitList { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;
        private string returnUrl;
		private AopObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetReturnUrl(string returnUrl){
            this.returnUrl = returnUrl;
        }

        public string GetReturnUrl(){
            return this.returnUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.member.consume.notify";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("act_pay_amount", this.ActPayAmount);
            parameters.Add("biz_card_no", this.BizCardNo);
            parameters.Add("card_info", this.CardInfo);
            parameters.Add("external_card_no", this.ExternalCardNo);
            parameters.Add("gain_benefit_list", this.GainBenefitList);
            parameters.Add("memo", this.Memo);
            parameters.Add("shop_code", this.ShopCode);
            parameters.Add("swipe_cert_type", this.SwipeCertType);
            parameters.Add("trade_amount", this.TradeAmount);
            parameters.Add("trade_name", this.TradeName);
            parameters.Add("trade_no", this.TradeNo);
            parameters.Add("trade_time", this.TradeTime);
            parameters.Add("trade_type", this.TradeType);
            parameters.Add("use_benefit_list", this.UseBenefitList);
            return parameters;
        }

		public AopObject GetBizModel()
        {
            return this.bizModel;
        }

        public void SetBizModel(AopObject bizModel)
        {
            this.bizModel = bizModel;
        }

        #endregion
    }
}
