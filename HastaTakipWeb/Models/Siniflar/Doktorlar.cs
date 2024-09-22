using System;
using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class Doktorlar
    {
        [Key]
        public int id { get; set; }
        public string doktorAdi { get; set; }
        public string doktorSoyadi { get; set; }
        public string Uzmanlık { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}