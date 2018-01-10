﻿using System.ComponentModel.DataAnnotations;

namespace Netnr.Login
{
    /// <summary>
    /// Step1：Oauth2/authorize
    /// 
    /// Url：https://open.taobao.com/docs/doc.htm?spm=a219a.7386797.0.0.XrMm8A&source=search&treeId=1&articleId=102635&docType=1
    /// 
    /// </summary>
    public class Taobao_Authorize_RequestEntity
    {
        public Taobao_Authorize_RequestEntity()
        {
            client_id = TaobaoConfig.AppKey;
            redirect_uri = TaobaoConfig.Redirect_Uri;
            state = System.Guid.NewGuid().ToString("N");
            view = "web";
        }

        private string _response_type = "code";
        /// <summary>
        /// 授权类型 ，值为code。
        /// </summary>
        [Required]
        public string response_type { get => _response_type; set => _response_type = value; }

        /// <summary>
        /// 等同于appkey，创建应用时获得。
        /// </summary>
        [Required]
        public string client_id { get; set; }

        /// <summary>
        /// redirect_uri指的是应用发起请求时，所传的回调地址参数，在用户授权后应用会跳转至redirect_uri。
        /// 要求与应用注册时填写的回调地址域名一致或顶级域名一致 。
        /// </summary>
        [Required]
        public string redirect_uri { get; set; }
        
        /// <summary>
        /// 维持应用的状态，传入值与返回值保持一致。
        /// </summary>
        public string state { get; set; }

        /// <summary>
        /// web,可选web、tmall或wap其中一种，默认为web。
        /// Web对应PC端（淘宝logo）浏览器页面样式；
        /// Tmall对应天猫的浏览器页面样式；
        /// Wap对应无线端的浏览器页面样式。
        /// </summary>
        public string view { get; set; }        
    }
}