using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    //网站入口控制器
    public class HomeController : Controller
    {
        //首页
        public ActionResult Index()
        {
            return View();
        }

        //测试页
        public ActionResult Test()
        {
            return View();
        }
    }
}