using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.user.member.card.update
    /// </summary>
    public class AlipayUserMemberCardUpdateRequest : IAopRequest<AlipayUserMemberCardUpdateResponse>
    {
        /// <summary>
        /// 商户会员卡余额
        /// </summary>
        public string Balance { get; set; }

        /// <summary>
        /// 会员卡卡号
        /// </summary>
        public string BizCardNo { get; set; }

        /// <summary>
        /// 发卡商户信息，json格式。  目前仅支持如下key：  &#61548; merchantUniId：商户唯一标识  &#61548; merchantUniIdType：支持以下3种取值。  LOGON_ID：商户登录ID，邮箱或者手机号格式；  UID：商户的支付宝用户号，以2088开头的16位纯数字组成；  BINDING_MOBILE：商户支付宝账号绑定的手机号。     注意：  本参数主要用于发卡平台接入场景，request_from为PLATFORM时，不能为空。
        /// </summary>
        public string CardMerchantInfo { get; set; }

        /// <summary>
        /// 扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。
        /// </summary>
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户会员卡号。   比如淘宝会员卡号、商户实体会员卡号、商户自有CRM虚拟卡号等
        /// </summary>
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// ALIPAY：支付宝  PARTNER：商户  PLATFORM：平台商
        /// </summary>
        public string IssuerType { get; set; }

        /// <summary>
        /// 商户会员卡会员等级
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// 时间戳参数-orrur_time（精确至毫秒），标识业务发生的时间  orrur_time 必须为long类型整数,时间维度目前未限制
        /// </summary>
        public string OrrurTime { get; set; }

        /// <summary>
        /// 商户会员卡积分
        /// </summary>
        public Nullable<long> Point { get; set; }

        /// <summary>
        /// 请求来源。  PLATFORM：发卡平台商  PARTNER：直联商户
        /// </summary>
        public string RequestFrom { get; set; }

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
            return "alipay.user.member.card.update";
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
            parameters.Add("balance", this.Balance);
            parameters.Add("biz_card_no", this.BizCardNo);
            parameters.Add("card_merchant_info", this.CardMerchantInfo);
            parameters.Add("ext_info", this.ExtInfo);
            parameters.Add("external_card_no", this.ExternalCardNo);
            parameters.Add("issuer_type", this.IssuerType);
            parameters.Add("level", this.Level);
            parameters.Add("orrur_time", this.OrrurTime);
            parameters.Add("point", this.Point);
            parameters.Add("request_from", this.RequestFrom);
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
