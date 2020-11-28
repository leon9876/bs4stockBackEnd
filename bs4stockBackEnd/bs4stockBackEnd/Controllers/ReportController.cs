using System;//舉報狀態
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using bs4stockBackEnd.DAL;
using bs4stockBackEnd.Models;
using bs4stockBackEnd.viewModels;

namespace bs4stockBackEnd.Controllers
{
    public class ReportController : Controller
    {
        private bs4stockBackEndContext context = new bs4stockBackEndContext();
        // 舉報列表
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
                int Count = context.Report.Count();
                ViewBag.Count = Count;

                VMRpt pageView = new VMRpt()
                {
                    Mber = context.Mber.ToList(),
                    Massage = context.Massage.Where(m => m.MsRptS == true).ToList(),
                    Report = context.Report.ToList(),
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

                int Count = context.Report.Where(m => m.Mber.UsLkC == selectorInt).Count();
                ViewBag.Count = Count;
                var pageView = new VMRpt
                {
                    Mber = context.Mber.ToList(),
                    Massage = context.Massage.Where(m => m.MsRptS == true).ToList(),
                    Report = context.Report.Where(m => m.Mber.UsLkC == selectorInt).ToList(),                 
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
        //按下有違規按鈕後，根據停權或永久停權，更正會員，舉報，留言資料表的資料內容
        public ActionResult violate(int? UsId)
        {
            Mber mber = context.Mber.Find(UsId);
            Massage massage = context.Massage.Find(UsId);
            Report report = context.Report.Find(UsId);

            mber.UsLkC += 1;
            mber.UsLkS = true;
            if (mber.UsLkC == 3) {
                mber.UsLkT = DateTime.Now;
                mber.UsULkT = DateTime.Now.AddYears(100);
            }
            else
            {
                mber.UsLkT = DateTime.Now;
                mber.UsULkT = DateTime.Now.AddDays(14);
            }
            massage.MsRptS = false;
            massage.MsHdS = true;

            context.Report.Remove(report);

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        //按下有違規按鈕後，舉報資料表刪除此筆舉報，此留言在留在資料表的隱藏狀態欄位變成true
        public ActionResult unViolate(int? UsId)
        {
            Massage massage = context.Massage.Find(UsId);
            Report report = context.Report.Find(UsId);

            massage.MsRptS = false;
            context.Report.Remove(report);
            context.SaveChanges();
            return RedirectToAction("Index");
        }        
        //搜尋條件:接收處理違規次數selector資料
        [HttpPost]
        public ActionResult Index(string selector)
        {
            Session["selector"] = selector;
            return RedirectToAction("Index");
        }
        //資料庫使用完畢，釋放資料庫空間
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
