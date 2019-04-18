using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    /// <summary>
    /// 用于Web.config的测试
    /// </summary>
    public class Test_WebConfigController : Controller
    {
        //首页
        public ActionResult Index()
        {
            //获取TestSectionGroup--TestSection--name节点下的值,该方法在.net 1.0版本中使用，过于老久，淘汰
            ViewData["TestSection"] = ((System.Collections.Specialized.NameValueCollection)System.Configuration.ConfigurationSettings.GetConfig("TestSectionGroup/TestSection"))["name"];

            //获取TestSectionGroup--TestSection--name节点下的值
            ViewData["TestSection"] = ((System.Collections.Specialized.NameValueCollection)System.Configuration.ConfigurationManager.GetSection("TestSectionGroup/TestSection"))["name"];

            

            //获取appSettings节点下的值
            ViewData["TestappSettings"] = System.Configuration.ConfigurationManager.AppSettings["webpages:Version"];
            
            //获取appSettings节点下的值
            ViewData["configSections"] = System.Configuration.ConfigurationManager.ConnectionStrings["ConnString"];

            return View();
        }
    }
}