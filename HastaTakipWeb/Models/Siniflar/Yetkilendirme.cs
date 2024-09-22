using System.ComponentModel.DataAnnotations;

namespace HastaTakipWeb.Models.Siniflar
{
    public class Yetkilendirme
    {
        [Key]
        public int Yönetimid { get; set; }
        public string Yetki { get; set; }
    }
}