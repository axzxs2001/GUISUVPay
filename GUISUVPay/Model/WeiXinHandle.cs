using SUISUVPayEntity.WeiXin;
using SUISUVPayEntity.WeiXin.ShaoMa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using SUISUVPay;
using Microsoft.Extensions.Options;
using SUISUVPayEntity.WeiXin.ShuaKa;

namespace SUISUVPay.Model
{
    /// <summary>
    /// 微信处理对象
    /// </summary>
    class WeiXinHandle
    {
        #region 初始化字段和构造函数
        /// <summary>
        /// 日志对象
        /// </summary>
        Logger _log;
        /// <summary>
        /// 配置参数
        /// </summary>
        AppSetting _setting;
        /// <summary>
        /// 微信处理对象构造
        /// </summary>
        /// <param name="appsetting">配置对象</param>
        /// <param name="log">日志对象</param>
        internal WeiXinHandle(IOptions<AppSetting> appsetting,Logger log)
        {
            _log = log;
            _setting = appsetting.Value;
        }
        #endregion

        #region 下单支付
        /// <summary>
        /// 统一下单
        /// </summary>
        /// <param name="unifiedOrder">预支付实体</param>
        /// <param name="unifiedOrderBack">预支付返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool SMUnifiedOrder(UnifiedOrder unifiedOrder, out UnifiedOrderBack unifiedOrderBack, out string message)
        {
            _log.Info("统一下单 SMUnifiedOrder 开始执行");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(unifiedOrder.Body) || string.IsNullOrEmpty(unifiedOrder.Out_Trade_No))
            {
                message = "商户订单或商品描述不能为空";
                _log.Error(message);
                unifiedOrderBack = null;
                return false;
            }
            if (unifiedOrder.Total_Fee < 0)
            {
                message = "标价金额不能小于0";
                _log.Error(message);
                unifiedOrderBack = null;
                return false;
            }
            data.SetValue("body", unifiedOrder.Body);//商品描述
            data.SetValue("out_trade_no", unifiedOrder.Out_Trade_No);//商户订单号
            data.SetValue("total_fee", unifiedOrder.Total_Fee);//总金额
            data.SetValue("trade_type", "NATIVE");//交易类型
            if (!string.IsNullOrEmpty(unifiedOrder.Detail))
            {
                data.SetValue("detail", unifiedOrder.Detail);//商品详情
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Attach))
            {
                data.SetValue("attach", unifiedOrder.Attach);//附加数据
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Fee_Type))
            {
                data.SetValue("fee_type", unifiedOrder.Fee_Type);//标价币种
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Time_Start))
            {
                data.SetValue("time_start", unifiedOrder.Time_Start);//交易起始时间
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Time_Expire))
            {
                data.SetValue("time_expire", unifiedOrder.Time_Expire);//交易结束时间
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Goods_Tag))
            {
                data.SetValue("goods_tag", unifiedOrder.Goods_Tag);//商品标记
            }
            if (!string.IsNullOrEmpty(unifiedOrder.Product_ID))
            {
                data.SetValue("product_id", unifiedOrder.Product_ID);//商品ID
            }
            //统一下单
            _log.Info("统一下单，WxPayApi.UnifiedOrder");
            var result = WxPayApi.UnifiedOrder(data);
            if (result.GetValue("return_code").ToString().ToUpper() == "SUCCESS" && result.GetValue("result_code").ToString().ToUpper() == "SUCCESS")
            {
                _log.Info("统一下单处理成功");
                unifiedOrderBack = new UnifiedOrderBack()
                {
                    Code_Url = result.GetValue("code_url")?.ToString(),
                    Err_Code = result.GetValue("err_code")?.ToString(),
                    Err_Code_Des = result.GetValue("err_code_des")?.ToString(),
                    Prepay_ID = result.GetValue("prepay_id")?.ToString(),
                    Result_Code = result.GetValue("result_code")?.ToString(),
                    Return_Code = result.GetValue("return_code")?.ToString(),
                    Return_Msg = result.GetValue("return_msg")?.ToString(),
                    Rrade_Type = result.GetValue("trade_type")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {

                var return_msg = result.GetValue("return_msg")?.ToString();
                var err_code_des = result.GetValue("err_code_des")?.ToString();
                message = $"{return_msg},{err_code_des}";
                _log.Error($"统一下单处理失败：{message}");
                unifiedOrderBack = null;
                return false;
            }
        }
        #endregion

        #region 退款
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="refund">退款实体</param>
        /// <param name="refundBack">退款返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool Refund(Refund refund, out RefundBack refundBack, out string message)
        {
            _log.Info("退款 Refund 开始执行");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(refund.Out_Trade_No) || string.IsNullOrEmpty(WxPayConfig.MCHID)|| string.IsNullOrEmpty(refund.Out_Refund_No))
            {
                message = "商户订单号，操作员，退款单号 不能为空";
                _log.Error(message);
                refundBack = null;
                return false;
            }        
            if (refund.Total_Fee < 0||refund.Refund_Fee < 0)
            {
                message = "订单总金额或退款金额不能为0";
                _log.Error(message);
                refundBack = null;
                return false;
            }
           
            data.SetValue("out_trade_no", refund.Out_Trade_No);
            data.SetValue("total_fee", refund.Total_Fee);//订单总金额
            data.SetValue("refund_fee",refund.Refund_Fee);//退款金额
            data.SetValue("out_refund_no", refund.Out_Refund_No);//商户退款单号
            data.SetValue("op_user_id", WxPayConfig.MCHID);//操作员，默认为商户号
            //退款
            _log.Info("退款 WxPayApi.Refund");
            var result = WxPayApi.Refund(data);
            _log.Info("Refund", "Refund process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == "SUCCESS" && result_code == "SUCCESS")
            {
                _log.Info("退款处理成功");
                refundBack = new RefundBack()
                {
                    Out_Trade_No = result.GetValue("out_trade_no")?.ToString(),
                    Out_Refund_No = result.GetValue("out_refund_no")?.ToString(),
                    Refund_Id = result.GetValue("refund_id")?.ToString(),
                    Refund_Channel = result.GetValue("refund_channel")?.ToString(),
                    Refund_Fee = Convert.ToInt32(result.GetValue("refund_fee")),
                    Settlement_Refund_Fee = result.GetValue("settlement_refund_fee") == null ? 0 : Convert.ToInt32(result.GetValue("settlement_refund_fee")),
                    Total_Fee = Convert.ToInt32(result.GetValue("total_fee")),
                    Settlement_Total_Fee = Convert.ToInt32(result.GetValue("settlement_total_fee")),
                    Fee_Type = result.GetValue("fee_type")?.ToString(),
                    Cash_Fee = Convert.ToInt32(result.GetValue("cash_fee")),
                    Cash_Fee_Type = result.GetValue("cash_fee_type ")?.ToString(),
                    Cash_Refund_Fee = result.GetValue("cash_refund_fee") == null ? 0 : Convert.ToInt32(result.GetValue("cash_refund_fee")),
                    Coupon_Type_Sn = result.GetValue("coupon_type_$n")?.ToString(),
                    Coupon_Refund_Fee = result.GetValue("coupon_refund_fee") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_fee")),
                    Coupon_Refund_Fee_Sn = result.GetValue("coupon_refund_fee_$n") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_fee_$n")),
                    Coupon_Refund_Count = result.GetValue("coupon_refund_count") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_count")),
                    Coupon_Refund_Id_Sn = result.GetValue("coupon_refund_id_$n")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"退款处理失败:{message}");
                refundBack = null;
                return false;
            }
        }


        #endregion

        #region 查询订单
        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="queryOrder">查询实体</param>
        /// <param name="queryOrderBack">查询返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool QueryOrder(QueryOrder queryOrder, out QueryOrderBack queryOrderBack, out string message)
        {
            _log.Info("查询订单 QueryOrder 开始执行");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(queryOrder.Out_Trade_No))
            {
                message = "商户订单号 不能为空";
                _log.Error(message);
                queryOrderBack = null;
                return false;
            }
            data.SetValue("out_trade_no", queryOrder.Out_Trade_No);
            //查询订单
            _log.Info("查询订单 WxPayApi.OrderQuery");
            var result = WxPayApi.OrderQuery(data);
            _log.Info("OrderQuery", "OrderQuery process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == "SUCCESS" && result_code == "SUCCESS")
            {
                _log.Info("查询订单成功！");
                queryOrderBack = new QueryOrderBack()
                {
                    Result_Code = result.GetValue("result_code")?.ToString(),
                    Err_Code = result.GetValue("result_code")?.ToString(),
                    Err_Code_Des = result.GetValue("result_code")?.ToString(),
                    Trade_Type = result.GetValue("trade_type")?.ToString(),
                    Trade_State = result.GetValue("trade_state")?.ToString(),
                    Bank_Type = result.GetValue("bank_type")?.ToString(),
                    Total_Fee = Convert.ToInt32(result.GetValue("total_fee")),
                    Settlement_Total_Fee = Convert.ToInt32(result.GetValue("settlement_total_fee")),
                    Fee_Type = result.GetValue("fee_type")?.ToString(),
                    Cash_Fee = Convert.ToInt32(result.GetValue("cash_fee")),
                    Cash_Fee_Type = result.GetValue("cash_fee_type ")?.ToString(),
                    Coupon_Fee = result.GetValue("coupon_fee") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_fee")),
                    Coupon_Count = result.GetValue("coupon_count") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_count")),
                    Coupon_Type_Sn = result.GetValue("coupon_type_$n")?.ToString(),
                    Coupon_Id_Sn = result.GetValue("coupon_id_$n")?.ToString(),
                    Coupon_Fee_Sn = result.GetValue("coupon_fee_$n") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_fee_$n")),
                    Transaction_Id = result.GetValue("transaction_id")?.ToString(),
                    Out_Trade_No = result.GetValue("err_code_des")?.ToString(),
                    Attach = result.GetValue("attach")?.ToString(),
                    Time_End = result.GetValue("time_end")?.ToString(),
                    Trade_State_Desc = result.GetValue("trade_state_desc")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"查询订单失败:{message}");
                queryOrderBack = null;
                return false;
            }
        }
        /// <summary>
        /// 字符串时间转时间
        /// </summary>
        /// <param name="timeStr">字符串时间格式，如：20170214163821</param>
        /// <returns>时间</returns>
        DateTime ToDateTime(string timeStr)
        {
            
            if (!string.IsNullOrEmpty(timeStr))
            {
                var list = new List<char>(timeStr.ToArray());
                list.Insert(12, ':');
                list.Insert(10, ':');
                list.Insert(8, ' ');
                list.Insert(6, '-');
                list.Insert(4, '-');
                return DateTime.Parse(new string(list.ToArray()));
            }
            else
            {
                throw new Exception("时间字符串为空！");
            }
        }
        #endregion

        #region 关闭订单
        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="closeOrder">关闭订单实体</param>
        /// <param name="closeOrderBack">关闭订单返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool CloseOrder(CloseOrder closeOrder, out CloseOrderBack closeOrderBack, out string message)
        {
            _log.Info("关闭订单 CloseOrder 开始执行");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(closeOrder.Out_Trade_No))
            {
                message = "商户订单号 不能为空";
                _log.Error(message);
                closeOrderBack = null;
                return false;
            }
            data.SetValue("out_trade_no", closeOrder.Out_Trade_No);
            //关闭订单
            _log.Info("WxPayApi.CloseOrder");
            var result = WxPayApi.CloseOrder(data);
            _log.Info("CloseOrder", "CloseOrder process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == "SUCCESS" && result_code == "SUCCESS")
            {
                _log.Info("关闭订单成功！");
                closeOrderBack = new CloseOrderBack()
                {
                    Err_Code = result.GetValue("err_code")?.ToString(),
                    Err_Code_Des = result.GetValue("err_code_des")?.ToString(),
                    Result_Code = result.GetValue("return_code")?.ToString(),
                    Result_Msg = result.GetValue("return_msg")?.ToString(),
                    Return_Code = result.GetValue("result_code")?.ToString(),
                    Return_Msg = result.GetValue("result_msg")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"关闭订单失败:{message}");
                closeOrderBack = null;
                return false;
            }
        }
        #endregion

        #region 退款查询
        /// <summary>
        /// 退款查询
        /// </summary>
        /// <param name="refundQuery">退款查询实体</param>
        /// <param name="refundQueryBack">退款查询返回实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool RefundQuery(RefundQuery refundQuery, out RefundQueryBack refundQueryBack, out string message)
        {
            _log.Info("退款查询 RefundQuery 开始");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(refundQuery.Out_Trade_No))
            {
                message = "商户订单号 不能为空";
                _log.Error(message);
                refundQueryBack = null;
                return false;
            }
            data.SetValue("out_trade_no", refundQuery.Out_Trade_No);
            //退款查询
            _log.Info("WxPayApi.RefundQuery");
            var result = WxPayApi.RefundQuery(data);
            _log.Info("RefundQuery", "RefundQuery process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == "SUCCESS" && result_code == "SUCCESS")
            {
                _log.Info("退款查询成功！");
                refundQueryBack = new RefundQueryBack()
                {
                    Err_Code = result.GetValue("err_code")?.ToString(),
                    Err_Code_Des = result.GetValue("err_code_des")?.ToString(),
                    Result_Code = result.GetValue("return_code")?.ToString(),
                    Return_Code = result.GetValue("result_code")?.ToString(),
                    Return_Msg = result.GetValue("result_msg")?.ToString(),
                    Cash_Fee = Convert.ToInt32(result.GetValue("cash_fee")),
                    Settlement_Refund_Fee_Sn = result.GetValue("settlement_refund_fee_$n") == null ? 0 : Convert.ToInt32(result.GetValue("settlement_refund_fee_$n")),
                    Coupon_Refund_Count_Sn = result.GetValue("coupon_refund_count_$n") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_count_$n")),
                    Coupon_Refund_Fee_Sn = result.GetValue("coupon_refund_fee_$n") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_fee_$n")),
                    Coupon_Refund_Fee_Sn_Sm = result.GetValue("coupon_refund_fee_$n_$m") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_refund_fee_$n_$m")),
                    Coupon_Refund_Id_Sn_Sm = result.GetValue("coupon_refund_id_$n_$m")?.ToString(),
                    Coupon_Type_Sn = result.GetValue("coupon_type_$n") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_type_$n")),
                    Fee_Type = result.GetValue("fee_type")?.ToString(),
                    Out_Refund_No_Sn = result.GetValue("out_refund_no_$n")?.ToString(),
                    Out_Trade_No = result.GetValue("out_trade_no")?.ToString(),
                    Refund_Account_Sn = result.GetValue("refund_account_$n")?.ToString(),
                    Refund_Channel_Sn = result.GetValue("refund_channel_$n")?.ToString(),
                    Refund_Count = Convert.ToInt32(result.GetValue("refund_count")),
                    Refund_Fee_Sn = Convert.ToInt32(result.GetValue("refund_fee_$n")),
                    Refund_Id_Sn = result.GetValue("refund_id_$n")?.ToString(),
                    Refund_Recv_Accout_Sn = result.GetValue("refund_recv_accout_$n")?.ToString(),
                    Refund_Status_Sn = result.GetValue("refund_status_$n")?.ToString(),
                    Settlement_Total_Fee = result.GetValue("settlement_total_fee ") == null ? 0 : Convert.ToInt32(result.GetValue("settlement_total_fee ")),
                    Total_Fee = Convert.ToInt32(result.GetValue("total_fee")),
                    Transaction_Id = result.GetValue("transaction_id")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"退款查询失败:{message}");
                refundQueryBack = null;
                return false;
            }
        }
        #endregion

        #region 下载对帐单
        /// <summary>
        /// 下载对帐单
        /// </summary>
        /// <param name="downLoadBill">对帐单请求实体</param>
        /// <param name="downLoadBillBack">对帐单应答实体</param>
        /// <param name="message">错误信息</param>
        /// <returns>交易是否成功</returns>
        internal bool DownLoadBill(DownLoadBill downLoadBill, out DownLoadBillBack downLoadBillBack, out string message)
        {
            _log.Info("下载对账单 DownLoadBill 开始");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(downLoadBill.Bill_Date)||string.IsNullOrEmpty(downLoadBill.Bill_Type))
            {
                message = "对账单日期，账单类型 不能为空";
                _log.Error(message);
                downLoadBillBack = null;
                return false;
            }
            data.SetValue("bill_date", downLoadBill.Bill_Date);
            data.SetValue("bill_type", downLoadBill.Bill_Type);
            if (!string.IsNullOrEmpty(downLoadBill.Tar_Type))
            {
                data.SetValue("tar_type", downLoadBill.Tar_Type);
            }
            //下载对帐单
            _log.Info("WxPayApi.DownloadBill");
            var result = WxPayApi.DownloadBill(data);
            _log.Info("DownLoadBill", "DownLoadBill process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == null && result_code == null)
            {
                _log.Info("下载对账单成功！");
                downLoadBillBack = new DownLoadBillBack()
                {
                    BackData = result.GetValue("result")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"下载对账单失败:{message}");
                downLoadBillBack = null;
                return false;

            }
        }
        #endregion

        #region 通知回调函数
        /// <summary>
        /// 通知回调函数
        /// </summary>
        /// <param name="backResult">回调传入实体</param>
        /// <returns>回调传出实体</returns>
        internal WxPayData NotiyCallBack(WxPayData backResult)
        {
            _log.Info("通知回调函数 NotiyCallBack 开始");
            try
            {
                var callBackUrl = _setting.WXNoticeCallBackUrl;
                var client = new RestSharp.RestClient(callBackUrl);
                var request = new RestSharp.RestRequest("", RestSharp.Method.POST);
                request.RequestFormat = RestSharp.DataFormat.Json;
                var return_code = backResult.GetValue("return_code")?.ToString().ToUpper();
                var result_code = backResult.GetValue("return_code")?.ToString().ToUpper();
                request.AddJsonBody(new PayResultNotify
                {                     
                    Return_Code = backResult.GetValue("return_code")?.ToString(),
                    Return_Msg = backResult.GetValue("return_msg")?.ToString(),
                    Result_Code = backResult.GetValue("result_code")?.ToString(),
                    Err_Code = backResult.GetValue("err_code")?.ToString(),
                    Err_Code_Des = backResult.GetValue("err_code_des")?.ToString(),
                    Trade_Type = backResult.GetValue("trade_type")?.ToString(),
                    Bank_Type = backResult.GetValue("bank_type")?.ToString(),
                    Total_Fee = Convert.ToInt32(backResult.GetValue("total_fee")),
                    Settlement_Total_Fee = Convert.ToInt32(backResult.GetValue("settlement_total_fee")),
                    Fee_Type = backResult.GetValue("fee_type")?.ToString(),
                    Cash_Fee = Convert.ToInt32(backResult.GetValue("cash_fee")),
                    Cash_Fee_Type = backResult.GetValue("cash_fee_type ")?.ToString(),
                    Coupon_Fee = backResult.GetValue("coupon_fee") == null ? 0 : Convert.ToInt32(backResult.GetValue("coupon_fee")),
                    Coupon_Count = backResult.GetValue("coupon_count") == null ? 0 : Convert.ToInt32(backResult.GetValue("coupon_count")),
                    Coupon_Type_Sn = backResult.GetValue("coupon_type_$n") == null ? 0 : Convert.ToInt32(backResult.GetValue("coupon_type_$n")),
                    Coupon_Id_Sn = backResult.GetValue("coupon_id_$n")?.ToString(),
                    Coupon_Fee_Sn = backResult.GetValue("coupon_fee_$n") == null ? 0 : Convert.ToInt32(backResult.GetValue("coupon_fee_$n")),
                    Transaction_Id = backResult.GetValue("transaction_id")?.ToString(),
                    Out_Trade_No = backResult.GetValue("out_trade_no")?.ToString(),
                    Attach = backResult.GetValue("attach")?.ToString(),
                    Time_End = backResult.GetValue("time_end")?.ToString(),
                });
                //回调通知
                _log.Info($"回调{callBackUrl}");
                var response = client.Execute(request);
                //处理回调返回结果
                var result = response.Content;
                _log.Info("回调成功！");
                PayResultNotifyBack notiyResult = Newtonsoft.Json.JsonConvert.DeserializeObject<PayResultNotifyBack>(result);
                var resultData = new WxPayData();
                resultData.SetValue("return_code", notiyResult.Return_Code);
                resultData.SetValue("return_msg", notiyResult.Return_Msg);
                return resultData;
            }
            catch (WeiXinPayException exc)
            {
                var resultData = new WxPayData();
                resultData.SetValue("return_code", "FAIL");
                resultData.SetValue("return_msg", exc.Message);
                _log.Fatal(exc,exc.Message);
                return resultData;
            }
        }
        #endregion

        #region 刷卡统一下单支付
        /// <summary>
        /// 刷卡统一下单支付
        /// </summary>
        /// <param name="microPay">刷卡统一下单实体</param>
        /// <param name="microPayBack">刷卡统一下单返回实体</param>
        /// <param name="message">错误消息</param>
        /// <returns>交易是否成功</returns>
        internal bool SKMicroPay(MicroPay microPay, out MicroPayBack microPayBack, out string message)
        {
            _log.Info("刷卡统一下单 MicroPay 开始");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(microPay.Body))
            {
                message = "商品描述 不能为空";
                _log.Error(message); 
                microPayBack = null;
                return false;
            }
            data.SetValue("body", microPay.Body);//商品描述
            if (!string.IsNullOrEmpty(microPay.Detail))
            {
                data.SetValue("detail", microPay.Detail);//商品详情
            }
            if (!string.IsNullOrEmpty(microPay.Attach))
            {
                data.SetValue("attach", microPay.Attach);//附加数据
            }
            data.SetValue("out_trade_no", microPay.Out_Trade_No);//商户订单号
            if (!string.IsNullOrEmpty(microPay.Fee_Type))
            {
                data.SetValue("fee_type", microPay.Fee_Type);//标价币种
            }
            data.SetValue("total_fee", Convert.ToInt32(microPay.Total_Fee));//总金额

            if (!string.IsNullOrEmpty(microPay.Goods_Tag))
            {
                data.SetValue("goods_tag", microPay.Goods_Tag);//商品标记
            }
            data.SetValue("auth_code", microPay.Auth_Code);//授权码
            //刷卡统一下单支付
            _log.Info("WxPayApi.Micropay");
            var result = WxPayApi.Micropay(data);
            if (result.GetValue("return_code").ToString().ToUpper() == "SUCCESS" && result.GetValue("result_code").ToString().ToUpper() == "SUCCESS")
            {
                _log.Info("刷卡统一下单支付成功！");
                microPayBack = new MicroPayBack()
                {
                    Err_Code = result.GetValue("err_code")?.ToString(),
                    Err_Code_Des = result.GetValue("err_code_des")?.ToString(),
                    Result_Code = result.GetValue("result_code")?.ToString(),
                    Return_Code = result.GetValue("return_code")?.ToString(),
                    Return_Msg = result.GetValue("return_msg")?.ToString(),
                    Attach = result.GetValue("attach")?.ToString(),
                    Bank_Type = result.GetValue("bank_type")?.ToString(),
                    Cash_Fee = Convert.ToInt32(result.GetValue("cash_fee")?.ToString()),
                    Cash_Fee_Type = result.GetValue("cash_fee_type")?.ToString(),
                    Coupon_Fee = result.GetValue("coupon_fee") == null ? 0 : Convert.ToInt32(result.GetValue("coupon_fee")),
                    Fee_Type = result.GetValue("fee_type")?.ToString(),
                    Is_Subscribe = result.GetValue("is_subscribe")?.ToString(),
                    Openid = result.GetValue("openid")?.ToString(),
                    Out_Trade_No = result.GetValue("out_trade_no")?.ToString(),
                    Settlement_Total_Fee = result.GetValue("settlement_total_fee ") == null ? 0 : Convert.ToInt32(result.GetValue("settlement_total_fee ")),
                    Time_End = result.GetValue("time_end")?.ToString(),
                    Total_Fee = Convert.ToInt32(result.GetValue("total_fee")?.ToString()),
                    Trade_Type = result.GetValue("trade_type")?.ToString(),
                    Transaction_Id = result.GetValue("transaction_id")?.ToString(),

                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg")?.ToString();
                var err_code_des = result.GetValue("err_code_des")?.ToString();
                message = $"{return_msg},{err_code_des}";
                _log.Error($"刷卡统一下单支付失败:{message}");
                microPayBack = null;
                return false;
            }
        }
        #endregion

        #region 刷卡撤销订单
        /// <summary>
        /// 刷卡撤销订单
        /// </summary>
        /// <param name="closeOrder">撤销订单实体</param>
        /// <param name="closeOrderBack">撤销订单返回实体</param>
        /// <param name="message">错误消息</param>
        /// <returns>交易是否成功</returns>
        internal bool CloseOrder(CloseOrder closeOrder, out SKCloseOrderBack closeOrderBack, out string message)
        {
            _log.Info("刷卡撤销订单 CloseOrder 开始");
            var data = new WxPayData();
            if (string.IsNullOrEmpty(closeOrder.Out_Trade_No))
            {
                message = "商户订单号 不能为空";
                _log.Error(message);
                closeOrderBack = null;
                return false;
            }
            data.SetValue("out_trade_no", closeOrder.Out_Trade_No);
            //刷卡撤销订单
            _log.Info("WxPayApi.Reverse");
            var result = WxPayApi.Reverse(data);
            _log.Info("CloseOrder", "CloseOrder process complete, result : " + result.ToXml());
            var return_code = result.GetValue("return_code")?.ToString().ToUpper();
            var result_code = result.GetValue("result_code")?.ToString().ToUpper();
            if (return_code == "SUCCESS" && result_code == "SUCCESS")
            {
                _log.Info("刷卡撤销订单成功！");
                closeOrderBack = new SKCloseOrderBack()
                {
                    Err_Code = result.GetValue("err_code")?.ToString(),
                    Err_Code_Des = result.GetValue("err_code_des")?.ToString(),
                    Result_Code = result.GetValue("return_code")?.ToString(),
                    Result_Msg = result.GetValue("return_msg")?.ToString(),
                    Return_Code = result.GetValue("result_code")?.ToString(),
                    Return_Msg = result.GetValue("result_msg")?.ToString(),
                    Recall = result.GetValue("recall")?.ToString()
                };
                message = "";
                return true;
            }
            else
            {
                var return_msg = result.GetValue("return_msg");
                var err_code_des = result.GetValue("err_code_des");
                message = $"{return_msg},{err_code_des}";
                _log.Error($"刷卡撤销订单失败:{message}");
                closeOrderBack = null;
                return false;
            }
        }

        #endregion
    }
}
