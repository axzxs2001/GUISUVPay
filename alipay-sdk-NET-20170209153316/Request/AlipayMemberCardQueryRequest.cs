using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.member.card.query
    /// </summary>
    public class AlipayMemberCardQueryRequest : IAopRequest<AlipayMemberCardQueryResponse>
    {
        /// <summary>
        /// 支付宝会员卡卡号。    注意：  biz_card_no和card_user_info不能同时为空。
        /// </summary>
        public string BizCardNo { get; set; }

        /// <summary>
        /// 发卡商户信息，json格式。  目前仅支持如下key：  merchantUniId：商户唯一标识  merchantUniIdType：支持以下3种取值。    LOGON_ID：商户登录ID，邮箱或者手机号格式；    UID：商户的支付宝用户号，以2088开头的16位纯数字组成；    BINDING_MOBILE：商户支付宝账号绑定的手机号。    注意：  本参数主要用于发卡平台接入场景，request_from为PLATFORM时，不能为空。
        /// </summary>
        public string CardMerchantInfo { get; set; }

        /// <summary>
        /// 持卡用户信息，json格式。  目前仅支持如下key：  userUniId：用户唯一标识  userUniIdType：支持以下3种取值。    LOGON_ID：用户登录ID，邮箱或者手机号格式；    UID：用户支付宝用户号，以2088开头的16位纯数字组成；    BINDING_MOBILE：用户支付宝账号绑定的手机号。    注意：  biz_card_no和card_user_info不能同时为空。
        /// </summary>
        public string CardUserInfo { get; set; }

        /// <summary>
        /// 扩展参数，json格式。  用于商户的特定业务信息的传递，只有商户与支付宝约定了传递此参数且约定了参数含义，此参数才有效。
        /// </summary>
        public string ExtInfo { get; set; }

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
            return "alipay.member.card.query";
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
            parameters.Add("biz_card_no", this.BizCardNo);
            parameters.Add("card_merchant_info", this.CardMerchantInfo);
            parameters.Add("card_user_info", this.CardUserInfo);
            parameters.Add("ext_info", this.ExtInfo);
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
