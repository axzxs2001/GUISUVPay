using System;
using System.Collections.Generic;
using System.Web;

namespace SUISUVPay
{
    public class WeiXinPayException : Exception 
    {
        public WeiXinPayException(string message) : base(message) 
        {
        }
     }
}