using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Areas.Admin.Controllers
{
    /// <summary>
    /// 用于路由的测试
    /// </summary>
    public class Test_RouteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}