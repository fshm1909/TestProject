using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //使用了具名参数
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "Web.Controllers" }//添加命名空间限制，即改路由配置只有Web.Controllers下的控制器能匹配，主要用于区分区域
            );


            //使用了具名参数
            routes.MapRoute(
                name: "test",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },//默认路由值
                constraints: new { },//约束
                namespaces: new[] { "Web.Controllers" }
            );
        }
    }
}
