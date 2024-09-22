using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int id { get; set; }
        public string bölümresimleri1 { get; set; }
        public string bölümadi1 { get; set; }
        public string aciklama1 { get; set; }
        public string bölümresimleri2 { get; set; }
        public string bölümadi2 { get; set; }
        public string aciklama2 { get; set; }
        public string bölümresimleri3 { get; set; }
        public string bölümadi3 { get; set; }
        public string aciklama3 { get; set; }
        

    }
}