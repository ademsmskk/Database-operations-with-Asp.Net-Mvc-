using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aaaaa.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DataClasses1DataContext ctx = new DataClasses1DataContext();
        public ActionResult Index()
        {
            List<Categories> ktg = ctx.Categories.ToList();

            return View(ktg);
        }
        public ActionResult Ekle()
        {
            return View();
        }

    }
}