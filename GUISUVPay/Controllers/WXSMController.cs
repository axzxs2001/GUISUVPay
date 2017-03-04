

using SUISUVPay.Model;
using System;
using Microsoft.AspNetCore.Mvc;
using NLog;
using Microsoft.Extensions.Options;
using SUISUVPayEntity.WeiXin;
using SUISUVPayEntity.WeiXin.ShaoMa;

namespace SUISUVPay.Controllers
{
    /// <summary>
    /// 微信扫码支付Controller
    /// </summary>
    [Route("api/[controller]")]
    public class WXSMController : PayController
    {
        #region 字段和构造函数
        /// <summary>
        /// 日志对象
        /// </summary>
        Logger _log;
        /// <summary>
        /// 微信处理对象
        /// </summary>
        WeiXinHandle wxHandle;
        /// <summary>
        /// 微信扫码支付Controller构造器
        /// </summary>
        /// <param name="appsetting">appsetting对象</param>
        public WXSMController(IOptions<AppSetting> appsetting)
        {            
            _log = LogManager.GetCurrentClassLogger();
            wxHandle = new WeiXinHandle(appsetting,_log);
        }
        #endregion

        #region 查询交易结果
        /// <summary>
        /// 查询交易结果
        /// </summary>
        /// <param name="orderNo">订单编号</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpGet("query")]
        public dynamic QueryPayResult(string orderNo)
        {
            try
            {
                _log.Info("查询交易结果");
                QueryOrderBack queryOrderBack;
                string message;
                var queryOrder = new QueryOrder()
                {
                    Out_Trade_No = orderNo
                };
                var result = wxHandle.QueryOrder(queryOrder, out queryOrderBack, out message);
                return BuildJsonResult(queryOrderBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"查询交易结果:{exc.Message}");
                return BuildJsonResult<QueryOrderBack>(null, false, exc.Message);
            }
        }
        #endregion

        #region 支付订单
        /// <summary>
        /// 扫码预支付接口
        /// </summary>
        /// <param name="unifiedOrder">预支付</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("unifiedorder")]
        public JsonResult PreparePay([FromBody]UnifiedOrder unifiedOrder)
        {
            try
            {
                _log.Info("扫码预支付接口");
                UnifiedOrderBack unifiedOrderBack;
                string message;
                var result = (wxHandle.SMUnifiedOrder(unifiedOrder, out unifiedOrderBack, out message));
                return BuildJsonResult(unifiedOrderBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"扫码预支付接口:{exc.Message}");
                return BuildJsonResult<UnifiedOrderBack>(null, false, exc.Message);
            }
        }
        #endregion

        #region 退单
        /// <summary>
        /// 退单
        /// </summary>
        /// <param name="refund">退单</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("refund")]
        public JsonResult RefundOrder([FromBody]Refund refund)
        {
            try
            {
                _log.Info("退单");
                RefundBack refundBack;
                string message;
                var result = wxHandle.Refund(refund, out refundBack, out message);
                return BuildJsonResult(refundBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"退单:{exc.Message}");
                return BuildJsonResult<RefundBack>(null, false, exc.Message);
            }

        }
        #endregion

        #region 关闭订单
        /// <summary>
        /// 关闭订单
        /// </summary>
        /// <param name="closeOrder">关闭订单</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("closeOrder")]
        public JsonResult CloseOrder([FromBody]CloseOrder closeOrder)
        {
            try
            {
                _log.Info("关闭订单");
                CloseOrderBack closeOrderBack;
                string message;
                var result = wxHandle.CloseOrder(closeOrder, out closeOrderBack, out message);
                return BuildJsonResult(closeOrderBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"关闭订单:{exc.Message}");
                return BuildJsonResult<CloseOrderBack>(null, false, exc.Message);
            }

        }
        #endregion

        #region 退款查询
        /// <summary>
        /// 退款查询
        /// </summary>
        /// <param name="refundQuery">退款查询</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("refundquery")]
        public JsonResult RefundQuery([FromBody]RefundQuery refundQuery)
        {
            try
            {
                _log.Info("退款查询");
                RefundQueryBack refundQueryBack;
                string message;
                var result = wxHandle.RefundQuery(refundQuery, out refundQueryBack, out message);
                return BuildJsonResult(refundQueryBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"退款查询:{exc.Message}");
                return BuildJsonResult<RefundQueryBack>(null, false, exc.Message);
            }

        }
        #endregion

        #region 下载对账单
        /// <summary>
        /// 下载对账单
        /// </summary>
        /// <param name="downLoadBill">下载对账单</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("downloadbill")]
        public JsonResult DownLoadBill([FromBody]DownLoadBill downLoadBill)
        {
            try
            {
                _log.Info("下载对账单");
                DownLoadBillBack downLoadBillBack;
                string message;
                var result = wxHandle.DownLoadBill(downLoadBill, out downLoadBillBack, out message);
                return BuildJsonResult(downLoadBillBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"下载对账单:{exc.Message}");
                return BuildJsonResult<DownLoadBillBack>(null, false, exc.Message);
            }
        }
        #endregion

        #region 支付通知
        /// <summary>
        /// 用户支付完后微信方回调该方法
        /// </summary>
        /// <returns>返回数据</returns>
        [HttpPost("notify")]
        public string PayResultNotiy()
        {
            var bytes = new Byte[Convert.ToInt32(Request.ContentLength)];
            Request.Body.Read(bytes, 0, bytes.Length);
            var content = System.Text.Encoding.UTF8.GetString(bytes);           
            _log.Info("支付通知");
            var backdata = new WxPayData();
            backdata.FromXml(content);
            var resultData = wxHandle.NotiyCallBack(backdata);
            var xml = resultData.ToXml();
            _log.Info($"支付通知返回：{xml}");
            return xml;
        }
        #endregion
    }

}

