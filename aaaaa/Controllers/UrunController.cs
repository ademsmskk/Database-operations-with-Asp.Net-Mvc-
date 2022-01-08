using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aaaaa.Controllers
{
    
    public class UrunController : Controller
    {
        
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        // GET: Urun
       

        public ActionResult Index()
        {
          
            List<Products> product = ctx.Products.ToList(); 
            return View(product);
        }
        public ActionResult UrunEkle()
        {
            ViewBag.Kategoriler = ctx.Categories.ToList();
            ViewBag.Tedarikciler = ctx.Suppliers.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult UrunEklee(Products b)
        {
            ctx.Products.InsertOnSubmit(b);
            ctx.SubmitChanges();
            return RedirectToAction("Index");

        }




    }
}