using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class DoktorHemsire
    {
        [Key]
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Uzmanlık { get; set; }
        public string Poliklinik { get; set; }
        public string Telefon { get; set; }
        public string KimlikNumarası { get; set; }
        
       
    }
}