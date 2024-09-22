using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HastaTakipWeb.Models.Siniflar
{
    public class IlacBilgileri
    {
        [Key]
        public int Ilacid { get; set; }
        public string IlacAdi { get; set; }
        public string IlacKullanımSekli { get; set; }
        public string IlacSahibi { get; set; }
        public string IlaciVerenDoktor { get; set; }
        public DateTime IlacVerilisTarihi { get; set; }
        public string KimlikNumarası {  get; set; }
    }
}