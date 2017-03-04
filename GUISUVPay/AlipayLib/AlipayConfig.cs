using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;

/// <summary>
/// Summary description for Config
/// </summary>
namespace SUISUVPay
{
    /*证书生成
      按照支付定要求进行
       1、 https://doc.open.alipay.com/doc2/detail.htm?spm=a219a.7629140.0.0.47hhnq&treeId=44&articleId=103242&docType=1
       2、生成工具（openssl-0.9.8h-1-setup）目录C:\Program Files (x86)\GnuWin32\bin
    */
    /// <summary>
    /// 支付宝配置文件
    /// </summary>
    public class AlipayConfig
    {

        public static string alipay_public_key = Environment.CurrentDirectory + @"\Alipay\\alipay_rsa_public_key.pem";
        //这里要配置没有经过PKCS8转换的原始私钥
        public static string merchant_private_key = Environment.CurrentDirectory + @"\Alipay\rsa_private_key.pem";
        public static string merchant_public_key = Environment.CurrentDirectory + @"\Alipay\rsa_public_key.pem";
        public static string AppId = "";
        public static string serverUrl = "https://openapi.alipay.com/gateway.do";
        public static string mapiUrl = "https://mapi.alipay.com/gateway.do";
        public static string PId = "";
        public static string NotifyUrl = "";

        public static string charset = "utf-8";//"utf-8";
        public static string sign_type = "RSA";
        public static string version = "1.0";


        static  AlipayConfig()
        {        
        }

        public static string getMerchantPublicKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_public_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

        public static string getMerchantPriveteKeyStr()
        {
            StreamReader sr = new StreamReader(merchant_private_key);
            string pubkey = sr.ReadToEnd();
            sr.Close();
            if (pubkey != null)
            {
                pubkey = pubkey.Replace("-----BEGIN PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("-----END PUBLIC KEY-----", "");
                pubkey = pubkey.Replace("\r", "");
                pubkey = pubkey.Replace("\n", "");
            }
            return pubkey;
        }

    }
}