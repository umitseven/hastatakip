using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class Admin
    {
        [Key]
        public int id { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string adSoyad { get; set; }
        public int Yönetimid { get; set; }
        public virtual Yetkilendirme Yetkilendirme { get; set; }
    }
}