using HastaTakipWeb.Models.Siniflar;
using Rotativa;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace HastaTakipWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admins
        Context c = new Context();
        

        public ActionResult SevenSaglikGrubu()
        {
            if (Session["kullaniciAdi"] != null)
            {
                int DoktorSayisi = c.DoktorHemsires.Count();
                int HastaSayisi = c.HastaBilgileris.Count();
                ViewBag.ToplamDoktorSayisi = DoktorSayisi;
                ViewBag.ToplamHastaSayisi = HastaSayisi;
                return View();
            }
            else
            {
                return RedirectToAction("GirisYap", "AnaSayfa");
            }

        }
        public ActionResult IndexAnaSayfa()
        {
            var deger = c.AnaSayfas.ToList();
            return View(deger);

        }

        public ActionResult AnasayfaGetir(int id)
        {
            var güncelle = c.AnaSayfas.Find(id);
            return View("AnasayfaGetir", güncelle);
        }
        public ActionResult AnasayfaGetir2(int id)
        {
            var güncelle = c.AnaSayfas.Find(id);
            return View("AnasayfaGetir2", güncelle);
        }

        public ActionResult AnasayfaGetir3(int id)
        {
            var güncelle = c.AnaSayfas.Find(id);
            return View("AnasayfaGetir3", güncelle);
        }

        public ActionResult AnasayfaGüncelle(AnaSayfa p)
        {
            var güncelle = c.AnaSayfas.Find(p.id);
            güncelle.bölümresimleri1 = p.bölümresimleri1;
            güncelle.aciklama1 = p.aciklama1;
            güncelle.bölümadi1 = p.bölümadi1;

            c.SaveChanges();
            return RedirectToAction("IndexAnaSayfa");
        }



        public ActionResult AnasayfaGüncelle2(AnaSayfa p)
        {
            var güncelle = c.AnaSayfas.Find(p.id);

            güncelle.bölümresimleri2 = p.bölümresimleri2;
            güncelle.aciklama2 = p.aciklama2;
            güncelle.bölümadi2 = p.bölümadi2;

            c.SaveChanges();
            return RedirectToAction("IndexAnaSayfa");
        }

        public ActionResult AnasayfaGüncelle3(AnaSayfa p)
        {
            var güncelle = c.AnaSayfas.Find(p.id);
            güncelle.bölümresimleri3 = p.bölümresimleri3;
            güncelle.aciklama3 = p.aciklama3;
            güncelle.bölümadi3 = p.bölümadi3;

            c.SaveChanges();
            return RedirectToAction("IndexAnaSayfa");
        }

        public ActionResult Hakkimizda()
        {
            var deger = c.Hakkimizdas.ToList();
            return View(deger);
        }

        public ActionResult HakkimizdaGetir(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir", güncelle);
        }
        public ActionResult HakkimizdaGetir2(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir2", güncelle);
        }
        public ActionResult HakkimizdaGetir3(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir3", güncelle);
        }
        public ActionResult HakkimizdaGetir4(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir4", güncelle);
        }
        public ActionResult HakkimizdaGetir5(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir5", güncelle);
        }
        public ActionResult HakkimizdaGetir6(int id)
        {
            var güncelle = c.Hakkimizdas.Find(id);
            return View("HakkimizdaGetir6", güncelle);
        }

        public ActionResult HakimmizdaGüncelle(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.Anabaslik = p.Anabaslik;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        public ActionResult HakimmizdaGüncelle2(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.baslik1 = p.baslik1;
            güncelle.aciklama1 = p.aciklama1;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        public ActionResult HakimmizdaGüncelle3(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.baslik2 = p.baslik2;
            güncelle.aciklama2 = p.aciklama2;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        public ActionResult HakimmizdaGüncelle4(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.baslik3 = p.baslik3;
            güncelle.aciklama3 = p.aciklama3;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        public ActionResult HakimmizdaGüncelle5(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.baslik4 = p.baslik4;
            güncelle.aciklama4 = p.aciklama4;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }
        public ActionResult HakimmizdaGüncelle6(Hakkimizda p)
        {
            var güncelle = c.Hakkimizdas.Find(p.id);
            güncelle.baslik5 = p.baslik5;
            güncelle.aciklama5 = p.aciklama5;

            c.SaveChanges();
            return RedirectToAction("Hakkimizda");
        }

        public ActionResult TopImage()
        {
            var deger = c.TopImages.ToList();
            return View(deger);
        }
        public ActionResult TopImageGetir(int id)
        {
            var güncelle = c.TopImages.Find(id);
            return View("TopImageGetir", güncelle);
        }

        public ActionResult TopImageGetir2(int id)
        {
            var güncelle = c.TopImages.Find(id);
            return View("TopImageGetir2", güncelle);
        }

        public ActionResult TopImageGetir3(int id)
        {
            var güncelle = c.TopImages.Find(id);
            return View("TopImageGetir3", güncelle);
        }

        public ActionResult TopImageGetir4(int id)
        {
            var güncelle = c.TopImages.Find(id);
            return View("TopImageGetir4", güncelle);
        }

        public ActionResult TopImageGetir5(int id)
        {
            var güncelle = c.TopImages.Find(id);
            return View("TopImageGetir5", güncelle);
        }

        public ActionResult TopImageGüncelle(TopImage p)
        {
            var güncelle = c.TopImages.Find(p.id);
            güncelle.resim = p.resim;

            c.SaveChanges();
            return RedirectToAction("TopImage");
        }

        public ActionResult TopImageGüncelle2(TopImage p)
        {
            var güncelle = c.TopImages.Find(p.id);
            güncelle.resim2 = p.resim2;

            c.SaveChanges();
            return RedirectToAction("TopImage");
        }

        public ActionResult TopImageGüncelle3(TopImage p)
        {
            var güncelle = c.TopImages.Find(p.id);
            güncelle.resim3 = p.resim3;

            c.SaveChanges();
            return RedirectToAction("TopImage");
        }

        public ActionResult TopImageGüncelle4(TopImage p)
        {
            var güncelle = c.TopImages.Find(p.id);
            güncelle.resim4 = p.resim4;

            c.SaveChanges();
            return RedirectToAction("TopImage");
        }

        public ActionResult TopImageGüncelle5(TopImage p)
        {
            var güncelle = c.TopImages.Find(p.id);
            güncelle.resim5 = p.resim5;

            c.SaveChanges();
            return RedirectToAction("TopImage");
        }

        public ActionResult Doktorlarimiz()
        {
            var deger = c.Doktorlars.OrderByDescending(d => d.CreatedDate).ToList();
            /*var deger = c.Doktorlars.ToList()*/;
            return View(deger);
        }
        public ActionResult DoktorlarimizGetir(int id)
        {
            var güncelle = c.Doktorlars.Find(id);
            return View("DoktorlarimizGetir", güncelle);
        }
        public ActionResult DoktorGüncelle(Doktorlar p)
        {
            var güncelle = c.Doktorlars.Find(p.id);
            güncelle.doktorAdi = p.doktorAdi;
            güncelle.doktorSoyadi = p.doktorSoyadi;
            güncelle.Uzmanlık = p.Uzmanlık;

            c.SaveChanges();
            return RedirectToAction("Doktorlarimiz");
        }
        [HttpGet]
        public ActionResult YeniDoktor()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YeniDoktor(Doktorlar p)
        {
            p.CreatedDate = DateTime.Now;
            c.Doktorlars.Add(p);
            c.SaveChanges();
            return RedirectToAction("Doktorlarimiz");
        }

        public ActionResult DoktorSil(int id)
        {
            var sil = c.Doktorlars.Find(id);
            c.Doktorlars.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Doktorlarimiz");
        }

        public PartialViewResult GirisIsim()
        {
            var deger = c.Admins.ToList();

            return PartialView(deger);
        }


        public async Task<ActionResult> Iletisim()
        { 
            var deger  = await c.Iletisims.OrderBy(a=>a.mesaj).ToListAsync();
            //var deger = c.Iletisims.ToList();
            return View(deger);
        }

        public ActionResult IletisimSil(int id)
        {
            var sil = c.Iletisims.Find(id);
            c.Iletisims.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }

        public ActionResult DoktorHemsire()
        {
            var deger = c.DoktorHemsires.ToList();
            return View(deger);
        }

        public ActionResult DoktorHemsireSil(int id)
        {
            var sil = c.DoktorHemsires.Find(id);
            c.DoktorHemsires.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("DoktorHemsire");
        }


        public ActionResult DoktorHemsireGetir(int id)
        {
            var güncelle = c.DoktorHemsires.Find(id);
            return View("DoktorHemsireGetir", güncelle);
        }

        public ActionResult DoktorHemsireGüncelle(DoktorHemsire p)
        {
            var güncelle = c.DoktorHemsires.Find(p.id);
            güncelle.Ad = p.Ad;
            güncelle.Soyad = p.Soyad;
            güncelle.Uzmanlık = p.Uzmanlık;
            güncelle.Poliklinik = p.Poliklinik;
            güncelle.Telefon = p.Telefon;
            güncelle.KimlikNumarası = p.KimlikNumarası;

            c.SaveChanges();
            return RedirectToAction("DoktorHemsire");

        }
        [HttpGet]
        public ActionResult YeniDoktorHemsireEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniDoktorHemsireEkle(DoktorHemsire p)
        {
            c.DoktorHemsires.Add(p);
            c.SaveChanges();
            return RedirectToAction("DoktorHemsire");
        }

        public ActionResult AdminYetkilendirme()
        {
            var deger = c.Admins.ToList();
            return View(deger);
            //var deger = await c.Admins.Where(a => a.adSoyad == "Ümit Seven").ToListAsync();//şar
            /* var deger =await c.Admins.OrderByDescending(a=>a.kullaniciAdi).ToListAsync();*///z-a
            //return View(deger);

        }

        public ActionResult AdminGetir(int id)
        {
            var güncelle = c.Admins.Find(id);
            return View("AdminGetir", güncelle);
        }


        public ActionResult AdiminYetkilendirmeSil(int id)
        {
            var sil = c.Admins.Find(id);
            c.Admins.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("AdminYetkilendirme");
        }


        public ActionResult AdminYetkilendirmeGüncelle(Admin p)
        {
            var güncelle = c.Admins.Find(p.id);
            güncelle.kullaniciAdi = p.kullaniciAdi;
            güncelle.sifre = p.sifre;
            güncelle.adSoyad = p.adSoyad;
            güncelle.Yönetimid = p.Yönetimid;

            c.SaveChanges();
            return RedirectToAction("AdminYetkilendirme");

        }
        [HttpGet]
        public ActionResult AdminYetkilendirmeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminYetkilendirmeEkle(Admin p)
        {
            c.Admins.Add(p);
            c.SaveChanges();
            return RedirectToAction("AdminYetkilendirme");
        }

        public ActionResult DoktorHemsireYönetim()
        {
            if (Session["kullaniciAdi"] != null)
            {
                int hastasayisi = c.HastaBilgileris.Count();
                ViewBag.ToplamHastaSayisi = hastasayisi;

                return View();
            }
            else
            {
                return RedirectToAction("GirisYap", "AnaSayfa");
            }
        }

        public ActionResult HastaBilgileri()
        {
            var deger = c.HastaBilgileris.ToList();
            return View(deger);
        }

        public ActionResult HastaBilgileriGetir(int id)
        {
            var güncelle = c.HastaBilgileris.Find(id);
            return View("HastaBilgileriGetir", güncelle);
        }
        public ActionResult HastaBilgileriGüncelle(HastaBilgileri p)
        {
            var güncelle = c.HastaBilgileris.Find(p.HastaId);
            güncelle.Ad = p.Ad;
            güncelle.Soyad = p.Soyad;
            güncelle.Cinsiyet = p.Cinsiyet;
            güncelle.DogumTarihi = p.DogumTarihi;
            güncelle.TelefonNumarası = p.TelefonNumarası;
            güncelle.KimlikNumarası = p.KimlikNumarası;

            c.SaveChanges();
            return RedirectToAction("HastaBilgileri");

        }

        public ActionResult HastaBilgileriSil(int id)
        {
            var sil = c.HastaBilgileris.Find(id);
            c.HastaBilgileris.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("HastaBilgileri");
        }
        public ActionResult HastaBilgileriSil2(int id)
        {
            var sil = c.HastaBilgileris.Find(id);
            c.HastaBilgileris.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("HastaBilgileri");
        }

        [HttpGet]
        public ActionResult YeniHastaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniHastaEkle(HastaBilgileri p)
        {
            c.HastaBilgileris.Add(p);
            c.SaveChanges();
            return RedirectToAction("HastaBilgileri");
        }

        public ActionResult PDFOLUSTUR()
        {
            
            var hastaBilgileri = c.HastaBilgileris.ToList();

            // PDF oluşturma işlemi için Rotativa kullanarak görünümü PDF'e dönüştür
            var pdf = new ViewAsPdf("PDFOLUSTUR", hastaBilgileri)
            {
                FileName = "HastaBilgileri.pdf" // İndirilen PDF dosyasının adı
            };

            return pdf;
        }

        public ActionResult PDFOLUSTURDoktorlarimiz()
        {
            
            var DoktorBilgileri = c.DoktorHemsires.ToList();  
            var pdf = new ViewAsPdf("PDFOLUSTURDoktorlarimiz", DoktorBilgileri)
            {
                FileName = "DoktorHemsireBilgileri.pdf"
            };

            return pdf;
        }

        public ActionResult PDFOLUSTURYönetimPaneli()
        {
            
            var YönetimBilgileri = c.Admins.ToList();

            
            var pdf = new ViewAsPdf("PDFOLUSTURYönetimPaneli", YönetimBilgileri)
            {
                FileName = "YönetimBilgileri.pdf"
            };

            return pdf;
        }

        public ActionResult RaporOlustur()
        {
            return View();
        }
        [HttpGet]
        public ActionResult HastaRaporlari()
        {
            
            var deger =c.hastaRaporlaris.ToList();
            return View(deger); 
        }

        [HttpGet]
        public ActionResult BütünMuayeneBilgileri()
        {
            var deger = c.muayeneBilgileris.ToList();
            return View(deger);

        }
        public async Task<ActionResult>HastaRaporlariGetir(string kimlikNumarası)
        {
            if (string.IsNullOrEmpty(kimlikNumarası))
            {
                return View();
            }

            var HastaRaporlariGetir = await c.hastaRaporlaris
                .Where(m => m.KimlikNumarası == kimlikNumarası)
                .ToListAsync();



            return View(HastaRaporlariGetir);
        }

        public async Task <ActionResult> MuayeneBilgileri(string kimlikNumarası)
        {
            //var deger = await c.muayeneBilgileris.Where(a => a.KimlikNumarası == ).ToListAsync();

            if (string.IsNullOrEmpty(kimlikNumarası))
            {
                return View();
            }
            

            var muayeneBilgileri = await c.muayeneBilgileris
                .Where(m => m.KimlikNumarası == kimlikNumarası)
                .ToListAsync();
            
            



            return View(muayeneBilgileri);
        }
        public ActionResult IlacBilgileriliste()
        {
            var deger =c.ılacBilgileris.ToList();
            return View(deger);

        }
        public async Task<ActionResult> IlacBilgileri(string kimlikNumarası)
        {
            //var deger = await c.muayeneBilgileris.Where(a => a.KimlikNumarası == ).ToListAsync();

            if (string.IsNullOrEmpty(kimlikNumarası))
            {
                return View();
            }


            var ilacBilgileri = await c.ılacBilgileris
                .Where(m => m.KimlikNumarası == kimlikNumarası)
                .ToListAsync();





            return View(ilacBilgileri);
        }
        [HttpGet]
        public ActionResult IlacBilgisiEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IlacBilgisiEkle(IlacBilgileri p/*HastaBilgileri a*/)
        {
            c.ılacBilgileris.Add(p);
            c.SaveChanges();
            //var getir = c.HastaBilgileris.Find(a.HastaId);
            //getir.Ad = a.Ad;
            //getir.Soyad = a.Soyad;
            //ViewBag.adi = getir.Ad;
            //ViewBag.Soyadi = getir.Soyad;
            //var muayeneId = await c.muayeneBilgileris.Where(a =>
            //a.HastaAdi == p.HastaAdi && a.HastaSoyadi == p.HastaSoyadi &&
            //a.Sikayet == p.Sikayet && a.DoktorAdi == p.DoktorAdi &&
            //a.MuayeneTarihi == p.MuayeneTarihi && a.Bulgular == p.Bulgular && a.Tedavi == p.Tedavi
            //).FirstOrDefaultAsync();


            return RedirectToAction("IlacBilgisiEkle");
        }
        public ActionResult IlacBilgisiSil(int id)
        {
            var sil = c.ılacBilgileris.Find(id);
            c.ılacBilgileris.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("IlacBilgileriliste");
        }
        public ActionResult IlacBilgiGetir(int id)
        {
            var güncelle = c.ılacBilgileris.Find(id);
            return View("IlacBilgiGetir", güncelle);
        }
       

        [HttpPost]
        public ActionResult IlacBilgisiGüncelle(IlacBilgileri p)
        {
            var güncelle = c.ılacBilgileris.Find(p.Ilacid);
            if (güncelle != null)
            {
                güncelle.IlacAdi = p.IlacAdi;
                güncelle.IlacKullanımSekli = p.IlacKullanımSekli;
                güncelle.IlacSahibi = p.IlacSahibi;
                güncelle.IlaciVerenDoktor = p.IlaciVerenDoktor;
                güncelle.IlacVerilisTarihi = p.IlacVerilisTarihi;
                güncelle.KimlikNumarası = p.KimlikNumarası;
               

                c.SaveChanges();
            }
            return RedirectToAction("IlacBilgileri");
        }

        public  ActionResult MuayeneBilgisiEkle()
        {
           
           
            return View();
        }
        [HttpGet]
        public ActionResult MuayeneBilgisiEkle(HastaBilgileri a,int? id)
        {
            if (a != null)
            {
                var getir = c.HastaBilgileris.Find(id);
                if (getir != null)
                {
                    ViewBag.Adi = getir.Ad;
                    ViewBag.Soyadi = getir.Soyad;
                    ViewBag.tc = getir.KimlikNumarası;
                    //a. = DateTime.Now;
                }
            }

            return View();
        }

        [HttpPost]
        public ActionResult MuayeneBilgisiEkle(MuayeneBilgileri p,HastaBilgileri a)
        {
            //var getir = c.HastaBilgileris.Find(a.KimlikNumarası);
            //getir.Ad = a.Ad;
            //getir.Soyad = a.Soyad;
            //ViewBag.adi = getir.Ad;
            //ViewBag.Soyadi = getir.Soyad;
            

            c.muayeneBilgileris.Add(p);
            c.SaveChanges();
            
            //var muayeneId = await c.muayeneBilgileris.Where(a =>
            //a.HastaAdi == p.HastaAdi && a.HastaSoyadi == p.HastaSoyadi &&
            //a.Sikayet == p.Sikayet && a.DoktorAdi == p.DoktorAdi &&
            //a.MuayeneTarihi == p.MuayeneTarihi && a.Bulgular == p.Bulgular && a.Tedavi == p.Tedavi
            //).FirstOrDefaultAsync();


            return RedirectToAction("MuayeneBilgisiEkle");
        }

        //public ActionResult MuayeneBilgisigetirme(HastaBilgileri a)
        //{
        //    var getir = c.HastaBilgileris.Find(a.KimlikNumarası);
            

        //    getir.Ad = a.Ad;
        //    getir.Soyad = a.Soyad;
        //    ViewBag.getir = getir.Ad;
        //    ViewBag.getir2 = getir.Soyad;


        //    return RedirectToAction("MuayeneBilgisiEkle");
        //}
        public ActionResult MuayeneBilgisiSil(int id)
        {
            var sil = c.muayeneBilgileris.Find(id);
            c.muayeneBilgileris.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("BütünMuayeneBilgileri");
        }
        [HttpGet]
        public ActionResult HastaRaporEkle()
        {
            
            return View();
        }
        
        [HttpPost]
        public ActionResult HastaRaporEkle(HastaRaporlari p)
        {
            c.hastaRaporlaris.Add(p);
            c.SaveChanges();

            return RedirectToAction("HastaRaporEkle");
        }
        public ActionResult HastaRaporeGetir(int id)
        {
            var güncelle = c.hastaRaporlaris.Find(id);
            return View("HastaRaporeGetir", güncelle);
        }

        [HttpPost]
        public ActionResult HastaRaporGüncelle(HastaRaporlari p)
        {
            var güncelle = c.hastaRaporlaris.Find(p.HastanınId);
            if (güncelle != null)
            {
                güncelle.Ad = p.Ad;
                güncelle.Soyad = p.Soyad;
                güncelle.Cinsiyet = p.Cinsiyet;
                güncelle.Teshis = p.Teshis;
                güncelle.ilac = p.ilac;
                güncelle.bakandoktor = p.bakandoktor;
                güncelle.tarih = p.tarih;
                güncelle.KimlikNumarası = p.KimlikNumarası;

                c.SaveChanges();
            }
            return RedirectToAction("HastaRaporlari");
        }
        public ActionResult HastaRaporSil(int id)
        {
            var sil = c.hastaRaporlaris.Find(id);
            c.hastaRaporlaris.Remove(sil);
            c.SaveChanges();
            return RedirectToAction("HastaRaporlari");
        }
        public ActionResult MuayeneGetir(int id)
        {
            var güncelle = c.muayeneBilgileris.Find(id);
            return View("MuayeneGetir", güncelle);
        }

        [HttpPost]
        public ActionResult MuayeneGüncelle(MuayeneBilgileri p)
        {
            var güncelle = c.muayeneBilgileris.Find(p.MuayeneId);
            if (güncelle != null)
            {
                güncelle.HastaAdi = p.HastaAdi;
                güncelle.HastaSoyadi = p.HastaSoyadi;
                güncelle.DoktorAdi = p.DoktorAdi;
                güncelle.MuayeneTarihi = p.MuayeneTarihi;
                güncelle.Sikayet = p.Sikayet;
                güncelle.Bulgular = p.Bulgular;
                güncelle.Tedavi = p.Tedavi;
                güncelle.Notlar = p.Notlar;
                güncelle.KimlikNumarası = p.KimlikNumarası;

                c.SaveChanges();
            }
            return RedirectToAction("BütünMuayeneBilgileri");
        }



        //public async Task<ActionResult> Contact()
        //{
        //    var deger = await c.Admins.OrderByDescending(c => c.adSoyad).ToListAsync();
        //    return View(deger);
        //}

    }


}