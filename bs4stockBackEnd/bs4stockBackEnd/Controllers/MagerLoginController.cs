using System; //管理員以及最高管理員登入,登出
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bs4stockBackEnd.Controllers;
using bs4stockBackEnd.DAL;
using bs4stockBackEnd.Models;

namespace bs4stockBackEnd.Controllers
{
    [checkLoginStatus(flag = false)]
    public class MagerLoginController : Controller
    {

        private bs4stockBackEndContext context = new bs4stockBackEndContext();
        //管理員或最高管理員登入
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string id, string pwd)
        {

            var mager = context.Mager.Where(m => m.MaAct == id && m.MaPwd == pwd).FirstOrDefault();

            if (mager == null)
            {
                ViewBag.Error = "帳號或密碼有誤!";
                return View();
            }          
                HttpContext.Session["mag"] = id;
                Session["AuthS"] = mager.AuthorityS;   
            return RedirectToAction("Index", "Arti");
        }
        //管理員或最高管理員登出
        public ActionResult Logout()
        {
            Session["mag"] = null;


            return RedirectToAction("Login");
        }
    }
}