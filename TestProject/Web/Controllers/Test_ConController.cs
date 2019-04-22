using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    /// <summary>
    /// 控制器的测试
    /// </summary>
    public class Test_ConController : Controller
    {
        public ActionResult Index()
        {
            User user = new User();
            user.Name = "用户名";
            //ViewData.Model = user;
            return View(user);
        }
    }
}