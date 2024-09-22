using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class Hakkimizda
    {
        [Key]
        public int id { get; set; }
        public string Anabaslik { get; set; }
        public string baslik1 { get; set; }
        public string aciklama1 { get; set; }
        public string baslik2 { get; set; }
        public string aciklama2 { get; set; }
        public string baslik3 { get; set; }
        public string aciklama3 { get; set; }
        public string baslik4 { get; set; }
        public string aciklama4 { get; set; }
        public string baslik5 { get; set; }
        public string aciklama5 { get; set; }


        
    }
}