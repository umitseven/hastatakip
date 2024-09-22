using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HastaTakipWeb.Models.Siniflar
{

    public class Iletisim
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string mail { get; set; }
        public string mesaj { get; set; }
        //[Column(TypeName = "date")]
        public DateTime tarih { get; set; }
       
    }
}