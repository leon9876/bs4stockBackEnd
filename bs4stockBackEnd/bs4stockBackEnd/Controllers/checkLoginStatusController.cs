using System; //違法用url進入網站者，強制導回登入頁面
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bs4stockBackEnd.Controllers
{
    public class checkLoginStatus : ActionFilterAttribute
    {
        //HttpContext context = HttpContext.Current;
        //非法用url網址的人，將他直接導向登入畫面
        public bool flag = true;

        void LoginStatus(HttpContext context)
        {

            if (context.Session["mag"] == null)
                context.Response.Redirect("/MagerLogin/Login");
        }
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            if (flag)
            {
                HttpContext context = HttpContext.Current;
                LoginStatus(context);
            }
        }
    }
}