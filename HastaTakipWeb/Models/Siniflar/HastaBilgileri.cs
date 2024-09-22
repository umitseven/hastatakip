using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaTakipWeb.Models.Siniflar
{
    public class HastaBilgileri
    {
        [Key]
        public int HastaId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Cinsiyet { get; set; }
        [Column(TypeName="date")]
        public DateTime DogumTarihi { get; set; }
        public string TelefonNumarası { get; set; }
        public string KimlikNumarası { get; set; }
     
    }
}