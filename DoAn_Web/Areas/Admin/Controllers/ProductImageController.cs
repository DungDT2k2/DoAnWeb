﻿using DoAn_Web.Models;
using DoAn_Web.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn_Web.Areas.Admin.Controllers
{
    public class ProductImageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/ProductImage
        public ActionResult Index(int id)
        {
            ViewBag.ProductId = id;
            var item = db.ProductImages.Where(x => x.ProductId == id).ToList();
            return View(item);
        }

        [HttpPost]
        public ActionResult AddImage(int productId, string url)
        {
            db.ProductImages.Add(new ProductImage
            {
                ProductId = productId,
                Image  = url,
                IsDefault = false
            });
            db.SaveChanges();
            return Json(new { Success = true });
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var item = db.ProductImages.Find(id);
            db.ProductImages.Remove(item);
            db.SaveChanges();
            return Json(new { success = true });
        }

    }
}