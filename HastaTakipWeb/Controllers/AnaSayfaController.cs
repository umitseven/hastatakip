using HastaTakipWeb.Models.Siniflar;
using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace HastaTakipWeb.Controllers
{
    public class AnaSayfaController : Controller
    {
        // GET: AnaSayfa
        Context c = new Context();

        public ActionResult Index()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);
        }

        public PartialViewResult topimage()
        {
            var deger = c.TopImages.ToList();
            return PartialView(deger);
        }
        public ActionResult Hakkimizda()
        {
            var deger = c.Hakkimizdas.ToList();
            return View(deger);
        }

        public ActionResult Doktorlarimiz()
        {
            var deger = c.Doktorlars.ToList();
            return View(deger);
        }

        [HttpGet]
        public ActionResult Iletisim()
        {
            return View();
        }
      

        [HttpPost]
        public ActionResult Iletisim(Iletisim p)
        {

            p.tarih = DateTime.Now;
            c.Iletisims.Add(p);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }


        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.kullaniciAdi == p.kullaniciAdi && x.sifre == p.sifre);

            if (bilgiler != null)
            {
                if (bilgiler.Yönetimid == 1) // Yönetim yetkisi 1 ise admin
                {
                    FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                    Session["kullaniciAdi"] = bilgiler.kullaniciAdi.ToString();
                    Session["adsoyad"] = bilgiler.adSoyad.ToString();
                    return RedirectToAction("SevenSaglikGrubu","Admin");
                }
                else if (bilgiler.Yönetimid == 3) // Yönetim yetkisi 3 ise doktor/hemşire
                {
                    FormsAuthentication.SetAuthCookie(bilgiler.kullaniciAdi, false);
                    Session["kullaniciAdi"] = bilgiler.kullaniciAdi.ToString();
                    Session["adsoyad"] = bilgiler.adSoyad.ToString();
                    return RedirectToAction("DoktorHemsireYönetim", "Admin");
                }
            }

            return View();
        }

        public ActionResult CikisYap()
        {
            FormsAuthentication.SignOut();
            Session["kullaniciAdi"] = null;
            Session["adsoyad"] = null;
            return RedirectToAction("GirisYap", "AnaSayfa");
        }


    }
}