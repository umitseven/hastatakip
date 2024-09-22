using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class TopImage
    {
        [Key]
        public int id { get; set; }
        public string resim { get; set; }
        public string resim2 { get; set; }
        public string resim3 { get; set; }
        public string resim4 { get; set; }
        public string resim5 { get; set; }

      
    }
}