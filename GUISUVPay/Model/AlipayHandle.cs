using Aop.Api;
using Aop.Api.Request;
using SUISUVPayEntity.Alipay;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using Aop.Api.Util;
using NLog;

namespace SUISUVPay.Model
{
    /// <summary>
    /// 支付宝处理类型
    /// </summary>
    class AlipayHandle
    {
        #region 支付宝类型初始化
        /// <summary>
        /// 支付宝客户端
        /// </summary>
        IAopClient client;
        /// <summary>
        /// 配置文件
        /// </summary>
        AppSetting _setting;
        /// <summary>
        /// 日志对象
        /// </summary>
        Logger _log;
        /// <summary>
        /// 支付宝处理类型构造
        /// </summary>
        /// <param name="appsetting">配置对象</param>
        /// <param name="log">日志对象</param>
        internal AlipayHandle(AppSetting appsetting,Logger log)
        {
            _log = log;
            _setting = appsetting;
            client = new DefaultAopClient(AlipayConfig.serverUrl, _setting.AlipayAppid, AlipayConfig.merchant_private_key, "json", AlipayConfig.version,
          AlipayConfig.sign_type, AlipayConfig.alipay_public_key, AlipayConfig.charset, true);
        }
        #endregion

        #region 扫码预支付
        /// <summary>
        /// 支付宝扫码预支付
        /// </summary>
        /// <param name="precreate">支付实体</param>
        /// <param name="alipaySMPayBack">支付返回实体</param>
        /// <param name="message">错误提示</param>
        /// <returns></returns>
        internal bool Precreate(Precreate precreate, out PrecreateBack alipaySMPayBack, out string message)
        {
            _log.Info("扫码预支付 Precreate 开始");
            var payRequst = new AlipayTradePrecreateRequest();
            payRequst.SetNotifyUrl(AlipayConfig.NotifyUrl);
            //生成bizcontent的json数据，并把默认值除掉
            payRequst.BizContent = JsonConvert.SerializeObject(precreate, new Newtonsoft.Json.JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            }).ToLower();
            var payResponse = client.Execute(payRequst);
            if (payResponse.Code == "10000")
            {
                _log.Info("扫码预支付成功！");
                alipaySMPayBack = new PrecreateBack()
                {
                    Code = payResponse.Code,
                    Msg = payResponse.Msg,
                    Out_Trade_No = payResponse.OutTradeNo,
                    Sub_Code = payResponse.SubCode,
                    Sub_Msg = payResponse.SubMsg,
                    Qr_Code = payResponse.QrCode
                };
                message = "";
                return true;
            }
            else
            {
                alipaySMPayBack = null;
                message = $"{ payResponse.Msg},{payResponse.SubMsg}";
                _log.Error($"扫码预支付失败:{message}");
                return false;
            }
        }
        #endregion

        #region 查询
        /// <summary>
        /// 支付宝查询
        /// </summary>
        /// <param name="query">查询实体</param>
        /// <param name="queryBack">查询返回寮体</param>
        /// <param name="message">错误信息</param>
        /// <returns></returns>
        internal bool Query(QueryOrder query, out QueryOrderBack queryBack, out string message)
        {
            _log.Info("支付宝查询 QueryOrder 开始");
            var queryRequst = new AlipayTradeQueryRequest();
            queryRequst.BizContent = Newtonsoft.Json.JsonConvert.SerializeObject(query, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore }).ToLower();
            var queryResponse = client.Execute(queryRequst);
            if (queryResponse.Code == "10000")
            {
                _log.Info("支付宝查询成功！");
                queryBack = new QueryOrderBack()
                {
                    Buyer_Logon_Id = queryResponse.BuyerLogonId,
                    Buyer_Pay_Amount = Convert.ToDecimal(queryResponse.BuyerPayAmount),
                    Buyer_User_Id = queryResponse.BuyerUserId,
                    Code = queryResponse.Code,
                    Discount_Goods_Detail = queryResponse.DiscountGoodsDetail,
                    Fund_Bill_List = GetTradeFundBills(queryResponse.FundBillList),
                    Industry_Sepc_Detail = queryResponse.IndustrySepcDetail,
                    Invoice_Amount = Convert.ToDecimal(queryResponse.InvoiceAmount),
                    Msg = queryResponse.Msg,
                    Out_Trade_No = queryResponse.OutTradeNo,
                    Point_Amount = Convert.ToDecimal(queryResponse.PointAmount),
                    Receipt_Amount = Convert.ToDecimal(queryResponse.ReceiptAmount),
                    Store_Name = queryResponse.StoreName,
                    Sub_Code = queryResponse.SubCode,
                    Sub_Msg = queryResponse.SubMsg,
                    Total_Amount = queryResponse.TotalAmount,
                    Trade_No = queryResponse.TradeNo,
                    Voucher_Detail_List = GetVoucherDetails(queryResponse.VoucherDetailList),
                    Alipay_Store_ID = queryResponse.AlipayStoreId,
                    Send_Pay_Date = Convert.ToDateTime(queryResponse.SendPayDate),
                    Store_ID = queryResponse.StoreId,
                    Terminal_ID = queryResponse.TerminalId,
                    Trade_Status = queryResponse.TradeStatus
                };
                message = "";
                return true;
            }
            else
            {
                queryBack = null;
                message = $"{ queryResponse.Msg},{queryResponse.SubMsg}";
                _log.Error($"支付宝查询失败:{message}");
                return false;
            }
        }





        /// <summary>
        /// 转换本交易支付时使用的所有优惠券信息
        /// </summary>
        /// <param name="vocherDetails"></param>
        /// <returns></returns>
        List<VoucherDetail> GetVoucherDetails(List<Aop.Api.Domain.VoucherDetail> vocherDetails)
        {
            var myVocherDetails = new List<VoucherDetail>();
            if (vocherDetails != null)
            {
                foreach (var vocherDetail in myVocherDetails)
                {
                    var myVocherDetail = new VoucherDetail()
                    {
                        Amount = vocherDetail.Amount,
                        Id = vocherDetail.Id,
                        Memo = vocherDetail.Memo,
                        Merchant_Contribute = vocherDetail.Merchant_Contribute,
                        Name = vocherDetail.Name,
                        Other_Contribute = vocherDetail.Other_Contribute,
                        Type = vocherDetail.Type
                    };
                    myVocherDetails.Add(myVocherDetail);
                }
            }
            return myVocherDetails;
        }
        #endregion

        #region 退款
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="refund">退款实体</param>
        /// <param name="refundBack">退款返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns></returns>
        internal bool Refund(Refund refund, out RefundBack refundBack, out string message)
        {
            _log.Info("退款 Refund 开始");
            var refundRequst = new AlipayTradeRefundRequest();
            refundRequst.BizContent = Newtonsoft.Json.JsonConvert.SerializeObject(refund, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore }).ToLower();
            var refundResponse = client.Execute(refundRequst);
            if (refundResponse.Code == "10000")
            {
                _log.Info("退款成功！");
                refundBack = new RefundBack()
                {
                    Buyer_Logon_Id = refundResponse.BuyerLogonId,
                    Buyer_User_Id = refundResponse.BuyerUserId,
                    Code = refundResponse.Code,
                    Fund_Change = refundResponse.FundChange,
                    Gmt_Refund_Pay = Convert.ToDateTime(refundResponse.GmtRefundPay),
                    Msg = refundResponse.Msg,
                    Open_Id = refundResponse.OpenId,
                    Out_Trade_No = refundResponse.OutTradeNo,
                    Refund_Detail_Item_List = GetTradeFundBills(refundResponse.RefundDetailItemList),
                    Refund_Fee = refundResponse.RefundFee,
                    Store_Name = refundResponse.StoreName,
                    Sub_Code = refundResponse.SubCode,
                    Sub_Msg = refundResponse.SubMsg,
                    Trade_No = refundResponse.TradeNo
                };
                message = "";
                return true;
            }
            else
            {
                refundBack = null;
                message = $"{ refundResponse.Msg},{refundResponse.SubMsg}";
                _log.Error($"退款失败:{message}");
                return false;
            }
        }
        /// <summary>
        /// 完成退款使用的资金渠道转换
        /// </summary>
        /// <param name="tradeFundBills"></param>
        /// <returns></returns>
        List<TradeFundBill> GetTradeFundBills(List<Aop.Api.Domain.TradeFundBill> tradeFundBills)
        {
            var myTradeFundBills = new List<TradeFundBill>();
            if (tradeFundBills != null)
            {
                foreach (var tradeFundBill in tradeFundBills)
                {
                    var myTradeFundBill = new TradeFundBill();
                    myTradeFundBill.Amount = Convert.ToDecimal(tradeFundBill.Amount);
                    myTradeFundBill.Fund_Channel = tradeFundBill.FundChannel;
                    myTradeFundBill.Real_Amount = string.IsNullOrEmpty(tradeFundBill.RealAmount) ? 0m : Convert.ToDecimal(tradeFundBill.RealAmount);
                    myTradeFundBills.Add(myTradeFundBill);
                }
            }
            return myTradeFundBills;
        }
        #endregion

        #region 撤销
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="cancelOrder">撤销订单</param>
        /// <param name="cancelOrderBack">撤销订单返回实体</param>
        /// <param name="message">错误消息</param>
        /// <returns></returns>
        internal bool Cancel(CancelOrder cancelOrder, out CancelOrderBack cancelOrderBack, out string message)
        {
            _log.Info("撤销 CancelOrder 开始");
            var cancelRequst = new AlipayTradeCancelRequest();
            cancelRequst.BizContent = Newtonsoft.Json.JsonConvert.SerializeObject(cancelOrder, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore }).ToLower();
            var cancelResponse = client.Execute(cancelRequst);
            if (cancelResponse.Code == "10000")
            {
                _log.Info("撤销成功！");
                cancelOrderBack = new CancelOrderBack()
                {
                    Action = cancelResponse.Action,
                    Code = cancelResponse.Code,
                    Msg = cancelResponse.Msg,
                    Out_Trade_No = cancelResponse.OutTradeNo,
                    Retry_Flag = cancelResponse.RetryFlag,
                    Sub_Code = cancelResponse.SubCode,
                    Sub_Msg = cancelResponse.SubMsg,
                    Trade_No = cancelResponse.TradeNo

                };
                message = "";
                return true;
            }
            else
            {
                cancelOrderBack = null;
                message = $"{ cancelResponse.Msg},{cancelResponse.SubMsg}";
                _log.Error($"撤销失败:{message}");
                return false;
            }
        }
        #endregion

        #region 下载对帐
        internal bool DownLoadUrlQuery(DownLoadUrlQuery downLoadUrlQuery, out DownLoadUrlQueryBack downLoadUrlQueryBack, out string message)
        {
            _log.Info("下载对账 DownLoadUrlQuery 开始");
            var downLoadUrlQueryRequst = new AlipayDataDataserviceBillDownloadurlQueryRequest();
            downLoadUrlQueryRequst.BizContent = JsonConvert.SerializeObject(downLoadUrlQueryRequst, new JsonSerializerSettings() { DefaultValueHandling = DefaultValueHandling.Ignore }).ToLower();
            var downLoadUrlQueryResponse = client.Execute(downLoadUrlQueryRequst);
            if (downLoadUrlQueryResponse.Code == "10000")
            {
                _log.Info("下载对账成功！");
                downLoadUrlQueryBack = new DownLoadUrlQueryBack()
                {
                    Code = downLoadUrlQueryResponse.Code,
                    Bill_Download_Url = downLoadUrlQueryResponse.BillDownloadUrl,
                    Msg = downLoadUrlQueryResponse.Msg,
                    Sub_Code = downLoadUrlQueryResponse.SubCode,
                    Sub_Msg = downLoadUrlQueryResponse.SubMsg
                };
                message = "";
                return true;
            }
            else
            {
                downLoadUrlQueryBack = null;
                message = $"{ downLoadUrlQueryResponse.Msg},{downLoadUrlQueryResponse.SubMsg}";
                _log.Error($"下载对账失败:{message}");
                return false;
            }
        }
        #endregion

        #region 条码支付
        /// <summary>
        /// 条码支付
        /// </summary>
        /// <param name="pay">条码支付实体</param>
        /// <param name="payBack">条码支付实体返回</param>
        /// <param name="message">错误信息</param>
        /// <returns></returns>
        internal bool Pay(Pay pay, out PayBack payBack, out string message)
        {
            _log.Info("条码支付 Pay 开始");
            var payRequst = new AlipayTradePayRequest();
            payRequst.SetNotifyUrl(AlipayConfig.NotifyUrl);
            payRequst.BizContent = JsonConvert.SerializeObject(pay, new Newtonsoft.Json.JsonSerializerSettings()
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            }).ToLower();
            var payResponse = client.Execute(payRequst);
            if (payResponse.Code == "10000")
            {
                _log.Info("条码支付成功！");
                payBack = new PayBack()
                {
                    Code = payResponse.Code,
                    Msg = payResponse.Msg,
                    Out_Trade_No = payResponse.OutTradeNo,
                    Sub_Code = payResponse.SubCode,
                    Sub_Msg = payResponse.SubMsg,
                    Buyer_Logon_Id = payResponse.BuyerLogonId,
                    Buyer_Pay_Amount = Convert.ToDecimal(payResponse.BuyerPayAmount),
                    Buyer_User_Id = payResponse.BuyerUserId,
                    Card_Balance = Convert.ToDecimal(payResponse.CardBalance),
                    Discount_Goods_Detail = payResponse.DiscountGoodsDetail,
                    Fund_Bill_List = GetTradeFundBills(payResponse.FundBillList),
                    Gmt_Payment = Convert.ToDateTime(payResponse.GmtPayment),
                    Invoice_Amount = Convert.ToDecimal(payResponse.InvoiceAmount),
                    Point_Amount = Convert.ToDecimal(payResponse.PointAmount),
                    Receipt_Amount = Convert.ToDecimal(payResponse.ReceiptAmount),
                    Store_Name = payResponse.StoreName,
                    Total_Amount = payResponse.TotalAmount,
                    Trade_No = payResponse.TradeNo,
                    Voucher_Detail_List = GetVoucherDetails(payResponse.VoucherDetailList)
                };
                message = "";
                return true;
            }
            else
            {
                payBack = null;
                message = $"{ payResponse.Msg},{payResponse.SubMsg}";
                _log.Error($"条码支付失败:{message}");
                return false;
            }
        }

        #endregion

        #region 通知回调函数
        /// <summary>
        /// 通知回调函数,支付宝要求返回success才表示收到异步通知
        /// </summary>
        /// <param name="content">回调内容</param>
        /// <returns></returns>
        internal string NotiyCallBack(string content)
        {
            try
            {
                _log.Info("通知回调函数 NotiyCallBack 开始");
                var dic = GetDic(content);
                //验证回调通知是否正确
                if (GetSignVeryfy(dic))
                {
                    _log.Info("通知回调函数成功！");
                    var payResultNotify = GetPayResultNotify(dic);
                    var client = new RestSharp.RestClient(_setting.AlipayNoticeCallBackUrl);
                    var request = new RestSharp.RestRequest("", RestSharp.Method.POST);
                    request.RequestFormat = RestSharp.DataFormat.Json;
                    request.AddJsonBody(payResultNotify);
                    var response = client.Execute(request);
                    return response.Content.ToLower();
                }
                else
                {
                    _log.Error("通知回调函数验证失败");
                    return "fail";
                }
            }
            catch(Exception exc)
            {
                _log.Fatal(exc,exc.Message);
                return "fail";
            }
        }

        /// <summary>
        /// 获取返回时的签名验证结果
        /// </summary>
        /// <param name="inputPara">通知返回参数数组</param>
        /// <param name="sign">对比的签名结果</param>
        /// <returns>签名验证结果</returns>
        bool GetSignVeryfy(SortedDictionary<string, string> inputPara)
        {
            var sign = inputPara["sign"];
            //获取待签名字符串
            var preSignStr = CreateLinkString(inputPara);
            //获得签名验证结果
            var isSign = false;
            if (!string.IsNullOrEmpty(sign))
            {
                isSign = AlipaySignature.RSACheckContent(preSignStr, sign, AlipayConfig.alipay_public_key, AlipayConfig.charset, AlipayConfig.sign_type, true);
            }
            return isSign;
        }
        /// <summary>
        /// 把数组所有元素，按照“参数=参数值”的模式用“&”字符拼接成字符串
        /// </summary>
        /// <param name="sArray">需要拼接的数组</param>
        /// <returns>拼接完成以后的字符串</returns>
        string CreateLinkString(SortedDictionary<string, string> dicArray)
        {
            var prestr = new StringBuilder();
            foreach (KeyValuePair<string, string> temp in dicArray)
            {
                prestr.Append(temp.Key + "=" + temp.Value + "&");
            }
            //去掉最后一个&字符
            var nLen = prestr.Length;
            prestr.Remove(nLen - 1, 1);

            return prestr.ToString();
        }

        /// <summary>
        /// 创建异步通知对象
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        PayResultNotify GetPayResultNotify(SortedDictionary<string, string> dic)
        {
            //把数据对dic中取出转成PayResultNotify对象
            var payResultNotify = new PayResultNotify();
            foreach (var pro in payResultNotify.GetType().GetProperties())
            {
                if (dic.ContainsKey(pro.Name.ToLower()))
                {
                    var value = Convert.ChangeType(dic[pro.Name.ToLower()], pro.PropertyType);
                    pro.SetValue(payResultNotify, value, null);
                }
            }
            return payResultNotify;
        }


        /// <summary>
        /// 装字符串转换成Dictionary
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        SortedDictionary<string, string> GetDic(string content)
        {
            var strArr = content.Split('&');
            var dic = new SortedDictionary<string, string>();
            foreach (var key in strArr)
            {
                var keyValue = key.Split(new string[] { "=" }, StringSplitOptions.None);
                if (keyValue.Length > 1 && !string.IsNullOrEmpty(keyValue[0]) && !string.IsNullOrEmpty(keyValue[1]))
                {
                    dic.Add(keyValue[0], keyValue[1]);
                }
            }
            return dic;
        }
        #endregion
    }
}