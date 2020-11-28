using System; //違規會員
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using bs4stockBackEnd.DAL;
using bs4stockBackEnd.Models;
using bs4stockBackEnd.viewModels;
namespace bs4stockBackEnd.Controllers
{
    public class lockMberController : Controller
    {
        private bs4stockBackEndContext context = new bs4stockBackEndContext();
        //違規會員列表
        public ActionResult Index(int page = 1)
        {
            ViewBag.AuthS = Session["AuthS"];
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            else if (Session["selector"] == null || Session["selector"].Equals(""))
            {
                ViewBag.flag = false;
                int Count = context.Mber.Where(m => m.UsLkC > 0).Count();
                ViewBag.Count = Count;
                var pageView = new VMpage
                {
                    Mber = context.Mber.Where(m => m.UsLkC > 0).ToList(),
                    PageSize = 10,
                    CurrentPage = page,
                };
                if (ViewBag.AuthS.Contains("管理權限"))
                {
                    return View("Index", "_Layout_TopManager", pageView);
                }
                    return View("Index", "_Layout_Manager", pageView);
            }
            else
            {
                ViewBag.flag = true;
                var selector = Session["selector"];
                int selectorInt = Convert.ToInt32(selector);

                int Count = context.Mber.Where(m => m.UsLkC == selectorInt).Count();
                ViewBag.Count = Count;
                var pageView = new VMpage
                {
                    Mber = context.Mber.Where(m => m.UsLkC == selectorInt).ToList(),
                    PageSize = 10,
                    CurrentPage = page,
                };
                if (ViewBag.AuthS.Contains("管理權限"))
                {
                    return View("Index", "_Layout_TopManager", pageView);
                }
                return View("Index", "_Layout_Manager", pageView);
            }
        }
        //搜尋條件:接收處理違規次數selector資料
        [HttpPost]
        public ActionResult Index(string selector)
        {
            Session["selector"] = selector;
            return RedirectToAction("Index");
        }
    }
}
