using DoAn_Web.Models;
using DoAn_Web.Models.EF;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn_Web.Areas.Admin.Controllers
{
    [Authorize(Roles = "Quản trị,Nhân viên")]
    public class CategoryController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Categroy
        public ActionResult Index()
        {
            var items = db.Categorys;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model) 
        {
            if(ModelState.IsValid)
            { 
                model.CreateDate = DateTime.Now;
                model.ModifiedDate = DateTime.Now;
                model.Alias = DoAn_Web.Models.Common.Filter.FilterChar(model.Title);
                db.Categorys.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.Categorys.Find(id);
            return  View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if (ModelState.IsValid)
            {
                db.Categorys.Attach(model);
                model.ModifiedDate = DateTime.Now;
                model.Alias = DoAn_Web.Models.Common.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x => x.Title).IsModified = true; 
                db.Entry(model).Property(x => x.Description).IsModified = true; 
                db.Entry(model).Property(x => x.Link).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true; 
                db.Entry(model).Property(x => x.SeoDescription).IsModified = true;
                db.Entry(model).Property(x => x.SeoKeywords).IsModified = true;
                db.Entry(model).Property(x => x.SeoTitle).IsModified = true;
                db.Entry(model).Property(x => x.Position).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedDate).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedBy).IsModified = true;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.Categorys.Find(id);
            if (item != null)
            {
                /*var DeleteItem = db.Categorys.Attach(item);*/
                db.Categorys.Remove(item);  
                db.SaveChanges() ;
                return Json(new { success = true });
            }
            return Json (new { success = false });
        }


    }
}