using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizedeneme6.Models.Entitiy;

namespace vizedeneme6.Controllers
{
    public class OgretmenController : Controller
    {
        // GET: Ogretmen
        SmyoEntities db = new SmyoEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Ogretmen.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniOgretmen()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniOgretmen(Tbl_Ogretmen p1)
        {
            db.Tbl_Ogretmen.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var Kategori = db.Tbl_Ogretmen.Find(id);
            db.Tbl_Ogretmen.Remove(Kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
 
        public ActionResult Guncelle(Tbl_Ogretmen p1)
        {
            var ktg = db.Tbl_Ogretmen.Find(p1.ogretid);
            ktg.ogretmenad = p1.ogretmenad;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}