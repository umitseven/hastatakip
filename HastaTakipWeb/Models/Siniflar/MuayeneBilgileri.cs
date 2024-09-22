using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace HastaTakipWeb.Models.Siniflar
{
    public class MuayeneBilgileri
    {
        [Key]
        public int MuayeneId { get; set; }
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
        public string DoktorAdi { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public string Sikayet { get; set; }
        public string Bulgular { get; set; }
        public string Tedavi { get; set; }
        public string Notlar { get; set; }
        public string KimlikNumarası { get; set; }
    }
}