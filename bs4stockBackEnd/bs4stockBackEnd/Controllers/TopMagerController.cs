using System; //最高管理者給管理者權限
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using bs4stockBackEnd.DAL;
using bs4stockBackEnd.Models;
using bs4stockBackEnd.viewModels;
namespace bs4stockBackEnd.Controllers
{
    
    public class TopMagerController : Controller
    {
        private bs4stockBackEndContext context = new bs4stockBackEndContext();

        //管理權限列表
        public ActionResult Index(int page=1)
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            
            ViewBag.topMager = context.Mager.Where(m=>m.AuthorityS.Contains("管理權限")).ToList();
            ViewBag.AuthS = Session["AuthS"];
            int Count = context.Mager.Where(m => m.Authority != 15).Count();
            ViewBag.Count = Count;
            var pageView = new VMpage
            {
            Mager = context.Mager.Where(m => m.Authority != 15).ToList(),
            PageSize = 10,
            CurrentPage = page,
            };
            ViewBag.AuthS = Session["AuthS"];
            if (ViewBag.AuthS.Contains("管理權限"))
            {
                return View("Index", "_Layout_TopManager", pageView);
            }
            return View("Index", "_Layout_Manager", pageView);
        }
        //新增管理員
        public ActionResult Create()
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            ViewBag.AuthS = Session["AuthS"];
            if (ViewBag.AuthS.Contains("管理權限"))
            {
                return View("Create", "_Layout_TopManager");
            }
            return View("Create", "_Layout_Manager");
        }

        //接收處理新增管理員表單資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Mager mager, bool edit, bool delete, bool create) //傳入view所帶來的checkbox參數
        {
            if (ModelState.IsValid)
            {
                int Authority = 0;
                String AuthorityS = "";
                Authority += create ? 1 : 0; //三元運算子
                AuthorityS += create ? "新增" + "\t" : "";
                Authority += delete ? 2 : 0;
                AuthorityS += delete ? "刪除" + "\t" : "";
                Authority += edit ? 4 : 0;
                AuthorityS += edit ? "修改" + "\t" : "";
                mager.Authority = Authority;
                mager.AuthorityS = AuthorityS;
                context.Mager.Add(mager);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mager);
        }

        //編輯管理員權限
        public ActionResult Edit(int? MaId)
        {
            if (Session["mag"] == null)
            {
                return RedirectToAction("Login", "MagerLogin");
            }
            if (MaId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mager Mager = context.Mager.Find(MaId);
            if (Mager == null)
            {
                return HttpNotFound();
            }
            ViewBag.AuthS = Session["AuthS"];
            if (ViewBag.AuthS.Contains("管理權限"))
            {
                return View("Edit", "_Layout_TopManager", Mager);
            }
            return View("Edit", "_Layout_Manager", Mager);
        }

        //接收處理編輯管理員表單資料
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Mager mager, bool edit, bool delete, bool create,int ? MaId)
        {
            var mag = context.Mager.Where(m => m.MaId == MaId).FirstOrDefault();
            if (ModelState.IsValid)
            {
                int Authority = 0;
                String AuthorityS = "";
                Authority += create ? 1 : 0;
                AuthorityS += create ? "新增" + "\t" : "";
                Authority += delete ? 2 : 0;
                AuthorityS += delete ? "刪除" + "\t" : "";
                Authority += edit ? 4 : 0;
                AuthorityS += edit ? "修改" + "\t" : "";
                mag.Authority = Authority;
                mag.AuthorityS = AuthorityS;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mager);
        }

        //刪除管理員
        public ActionResult Delete(int? MaId)
        {
            Mager mager = context.Mager.Find(MaId);
            context.Mager.Remove(mager);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}
