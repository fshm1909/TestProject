using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    /// <summary>
    /// T4模板测试
    /// </summary>
    public class Test_T4Controller : Controller
    {
        // GET: Test_T4
        public ActionResult Index()
        {
            return View();
        }
    }
}