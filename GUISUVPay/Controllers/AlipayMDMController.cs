using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SUISUVPayEntity.Alipay;
using System;
using SUISUVPay.Model;
using NLog;

namespace SUISUVPay.Controllers
{

    /// <summary>
    /// 支付宝扫码Controller
    /// </summary>
    [Route("api/[controller]")]
    public class AlipayMDMController : PayController
    {
        #region 字段和构造函数
        /// <summary>
        /// 日志对象
        /// </summary>
        Logger _log;
        /// <summary>
        /// 支付宝处理对象
        /// </summary>
        AlipayHandle alipayHandle;
        /// <summary>
        /// 支付宝Controller构造函数
        /// </summary>
        /// <param name="appSettingOpt">AppSettings配置类</param>
        public AlipayMDMController(IOptions<AppSetting> appSettingOpt)
        {
            _log = LogManager.GetCurrentClassLogger();
            alipayHandle = new AlipayHandle(appSettingOpt.Value, _log);
            
        }
        #endregion

        #region 查询交易
        /// <summary>
        /// 查询交易
        /// </summary>
        /// <param name="Out_Trade_No">订单编号</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpGet("query")]
        public JsonResult QueryOrder(string Out_Trade_No)
        {
            try
            {
                _log.Info("查询交易");
                QueryOrderBack queryBack;
                string message;
                var query = new QueryOrder() { Out_Trade_No = Out_Trade_No };
                var result = alipayHandle.Query(query, out queryBack, out message);
                return BuildJsonResult(queryBack, result, message);
            }
            catch (Exception exc)
            {               
                _log.Fatal(exc,$"查询交易:{exc.Message}"); 
                return BuildJsonResult<QueryOrderBack>(null, false, exc.Message);
            }
        }
        #endregion

        #region 扫码支付
        /// <summary>
        /// 扫码支付
        /// </summary>
        /// <param name="precreate">扫码支付</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("precreate")]
        public JsonResult PreparePay([FromBody]Precreate precreate)
        {
            _log.Info("扫码支付");
            try
            {
                PrecreateBack precreateBack;
                string message;
                var result = alipayHandle.Precreate(precreate, out precreateBack, out message);
                return BuildJsonResult(precreateBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"扫码支付:{exc.Message}");
                return BuildJsonResult<PrecreateBack>(null, false, exc.Message);
            }
        }
        #endregion

        #region 退款
        /// <summary>
        /// 退款
        /// </summary>
        /// <param name="refund">退款</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("refund")]
        public JsonResult RefundOrder([FromBody]Refund refund)
        {
            try
            {
                _log.Info("退款");
                RefundBack refundBack;
                string message;
                var result = alipayHandle.Refund(refund, out refundBack, out message);
                return BuildJsonResult<RefundBack>(refundBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"退款:{exc.Message}");
                return BuildJsonResult<RefundBack>(null, false, exc.Message);
            }

        }
        #endregion

        #region 支付通知
        /// <summary>
        /// 用户支付完后支付宝方回调该方法
        /// </summary>
        /// <returns></returns>
        [HttpPost("notify")]
        public string PayResultNotiy()
        {
            _log.Info("支付通知");
            var bytes = new Byte[Convert.ToInt32(Request.ContentLength)];
            Request.Body.Read(bytes, 0, bytes.Length);
            var content = System.Text.Encoding.UTF8.GetString(bytes);
            return alipayHandle.NotiyCallBack(content);
        }

        #endregion

        #region 撤销
        /// <summary>
        /// 撤销
        /// </summary>
        /// <param name="cancelOrder">撤销</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("cancel")]
        public JsonResult RefundOrder([FromBody]CancelOrder cancelOrder)
        {
            try
            {
                _log.Info("撤销");
                CancelOrderBack cancelOrderBack;
                string message;
                var result = alipayHandle.Cancel(cancelOrder, out cancelOrderBack, out message);
                return BuildJsonResult<CancelOrderBack>(cancelOrderBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"撤销:{exc.Message}");
                return BuildJsonResult<CancelOrderBack>(null, false, exc.Message);
            }

        }
        #endregion

        #region 条码支付
        /// <summary>
        /// 条码支付
        /// </summary>
        /// <param name="pay">条码支付</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("pay")]        
        public JsonResult Pay([FromBody]Pay pay)
        {
            try
            {
                _log.Info("条码支付");
                PayBack payBack;
                string message;
                var result = alipayHandle.Pay(pay, out payBack, out message);
                return BuildJsonResult(payBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"条码支付:{exc.Message}");
                return BuildJsonResult<PrecreateBack>(null, false, exc.Message);
            }
        }

        #endregion

        #region 对帐下载
        /// <summary>
        /// 对帐下载
        /// </summary>
        /// <param name="downLoadUrlQuery">对帐下载</param>
        /// <returns>返回一个附带实体的BackResult对象</returns>
        [HttpPost("downloadquery")]
        public JsonResult DownLoadUrlQuery([FromBody]DownLoadUrlQuery downLoadUrlQuery)
        {
            try
            {
                _log.Info("对账下载");
                DownLoadUrlQueryBack downLoadUrlQueryBack;
                string message;
                var result = alipayHandle.DownLoadUrlQuery(downLoadUrlQuery, out downLoadUrlQueryBack, out message);
                return BuildJsonResult<DownLoadUrlQueryBack>(downLoadUrlQueryBack, result, message);
            }
            catch (Exception exc)
            {
                _log.Fatal(exc,$"对账下载:{exc.Message}");
                return BuildJsonResult<DownLoadUrlQueryBack>(null, false, exc.Message);
            }

        }

        #endregion
    }


}
