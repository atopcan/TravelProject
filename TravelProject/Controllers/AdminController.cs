using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Sınıflar;

namespace TravelProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult YeniBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult BlogSil(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bul = c.Blogs.Find(id);

            return View("BlogGetir", bul);
        }
        public ActionResult BlogGuncelle(Blog b)
        {
            var bg = c.Blogs.Find(b.Id);
            bg.aciklama = b.aciklama;
            bg.baslik = b.baslik;
            bg.blogImage = b.blogImage;
            bg.tarih = b.tarih;

            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult YorumListesi()
        {
            var yorumlar = c.Yorumlars.ToList();

            return View(yorumlar);
        }
        public ActionResult YorumSil(int id )
        {
            var b = c.Yorumlars.Find(id);
            c.Yorumlars.Remove(b);
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
        public ActionResult YorumGetir(int id)
        {
            var yorum = c.Yorumlars.Find(id);

            return View("YorumGetir", yorum);
        }
        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yg = c.Yorumlars.Find(y.Id);
            yg.kullaniciAdi = y.kullaniciAdi;
            yg.mail = y.mail;
            yg.yorum = y.yorum;
            c.SaveChanges();

            return RedirectToAction("YorumListesi");
        }
    }
}