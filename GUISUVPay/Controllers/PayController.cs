using SUISUVPayEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SUISUVPay.Model;


namespace SUISUVPay.Controllers
{
    public class PayController : Controller
    {      
        /// <summary>
        /// 生成JSON对象
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        protected JsonResult BuildJsonResult<T>(T entity,bool result=true,string message="")
        {            
            var backResult = new BackResult<T>();
            backResult.Result = result;
            backResult.Message = message;
            backResult.Entity = entity;
            var back= new JsonResult(backResult, new Newtonsoft.Json.JsonSerializerSettings());
            return back;
        }
    }

 
}
