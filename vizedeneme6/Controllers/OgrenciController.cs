using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizedeneme6.Models.Entitiy;

namespace vizedeneme6.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        SmyoEntities db=new SmyoEntities(); 
        public ActionResult Index()
        {
            var degerler = db.Tbl_Ogrenci.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniOgrenci(Tbl_Ogrenci p1)
        {
            db.Tbl_Ogrenci.Add(p1);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int id)
        {
            var Kategori = db.Tbl_Ogrenci.Find(id);
            db.Tbl_Ogrenci.Remove(Kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
     
        public ActionResult Guncelle(Tbl_Ogrenci p1)
        {
            var ktg = db.Tbl_Ogrenci.Find(p1.ogrid);
            ktg.ogrid = p1.ogrid;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}