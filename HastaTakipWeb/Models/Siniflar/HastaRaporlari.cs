using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaTakipWeb.Models.Siniflar
{
    public class HastaRaporlari
    {
        [Key]
        public int HastanınId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        public string Teshis { get; set; }
        public string ilac {  get; set; }
        public string bakandoktor { get; set; }

        [Column(TypeName = "date")]
        public DateTime tarih {  get; set; }
        public string KimlikNumarası { get; set; }

    }
}