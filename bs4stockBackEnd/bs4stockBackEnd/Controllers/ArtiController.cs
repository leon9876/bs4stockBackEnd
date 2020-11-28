using System; //影音文章
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PagedList;
using PagedList.Mvc;
using bs4stockBackEnd.DAL;
using bs4stockBackEnd.Models;
using bs4stockBackEnd.viewModels;

namespace bs4stockBackEnd.Controllers
{
    public class ArtiController : Controller
    {
        bs4stockBackEndContext context = new bs4stockBackEndContext();
        //影音文章列表
        public ActionResult Index(int page = 1)
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            ViewBag.AuthS = Session["AuthS"];
            int Count = context.Arti.Count();
            ViewBag.Count = Count;
            var pageView = new VMpage
            {
                Arti = context.Arti.ToList(),
                PageSize = 10,
                CurrentPage = page,
               
            };
            if (ViewBag.AuthS.Contains("管理權限"))//如果登入者的權限有"管理權限"字串，給最高管理者專屬的layout。
            {
                return View("Index","_Layout_TopManager", pageView);
            }
            return View("Index","_Layout_Manager", pageView);//登入者為管理者，給管理者專屬的layout。
        }
        //測試影音文章專區
        public ActionResult Show(int page=1)
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            ViewBag.AuthS = Session["AuthS"];
            int Count = context.Arti.Count();
            ViewBag.Count = Count;
            var pageView = new VMpage
            {
                Arti = context.Arti.ToList(),
                PageSize = 9,
                CurrentPage = page,

            };
            if (ViewBag.AuthS.Contains("管理權限"))//如果登入者的權限有"管理權限"字串，給最高管理者專屬的layout。
            {
                return View("Show", "_Layout_TopManager", pageView);
            }
            return View("Show", "_Layout_Manager", pageView);//登入者為管理者，給管理者專屬的layout。
        }   
        //新增影音文章(顯示新增畫面)
        public ActionResult Create()
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            ViewBag.AuthS = Session["AuthS"];
            if (ViewBag.AuthS.Contains("管理權限"))//如果登入者的權限有"管理權限"字串，給最高管理者專屬的layout。
            {
                return View("Create", "_Layout_TopManager");
            }
            return View("Create", "_Layout_Manager");//登入者為管理者，給管理者專屬的layout。
        }

        //新增影音文章(接收處理表單資料)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Arti Arti)
        {
            if (ModelState.IsValid)
            {
                context.Arti.Add(Arti);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Arti);
        }
        //編輯影音文章(顯示編輯畫面)
        public ActionResult Edit(int? id)
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            ViewData["Date"] = DateTime.Now;

            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Arti Arti = context.Arti.Find(id);
            if (Arti == null) { 
                return HttpNotFound();
            }
            ViewBag.AuthS = Session["AuthS"];
            if (ViewBag.AuthS.Contains("管理權限"))//如果登入者的權限有"管理權限"字串，給最高管理者專屬的layout。
            {
                return View("Edit", "_Layout_TopManager",Arti);
            }
            return View("Edit", "_Layout_Manager", Arti);//登入者為管理者，給管理者專屬的layout。
        }
        //編輯影音文章(接收處理編輯表單資料)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ArId,ArName,ArCt")] Arti Arti)
        {
            if (ModelState.IsValid)
            {
                context.Entry(Arti).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Arti);
        }
        public ActionResult Delete(int? ArId)
        {
            Arti Arti = context.Arti.Find(ArId);
            context.Arti.Remove(Arti);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}