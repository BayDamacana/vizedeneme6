using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vizedeneme6.Models.Entitiy;

namespace vizedeneme6.Controllers
{
    public class RaporController : Controller
    {
        // GET: Rapor
        SmyoEntities db = new SmyoEntities();
        public ActionResult Index()
        {
            var degerler = db.Tbl_Ogretmen.ToList();
            var degerler1 = db.Tbl_Ogrenci.ToList();
            return View(degerler);
            return View(degerler1);
        }
        [HttpGet]
        public ActionResult Yenikategori()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Yenikategori(Tbl_Ogrenci p1)
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
        public ActionResult KategoriGetir(int id)
        {
            var ktgr = db.Tbl_Ogrenci.Find(id);
            return View("KategoriGetir", ktgr);
        }
        public ActionResult Guncelle(Tbl_Ogrenci p1)
        {
            var ktg = db.Tbl_Ogrenci.Find(p1.ogrid);
            ktg.ograd = p1.ograd;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}