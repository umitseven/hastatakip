using System.Data.Entity;
using System.Reflection.Emit;

namespace HastaTakipWeb.Models.Siniflar
{
    public class Context : DbContext
    {
        public Context():base ("name=Context") { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<TopImage> TopImages { get; set; }
        public DbSet<Hakkimizda> Hakkimizdas { get; set; }
        public DbSet<Doktorlar> Doktorlars { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Yetkilendirme> Yetkilendirmes { get; set; }
        public DbSet<DoktorHemsire> DoktorHemsires { get; set; }
        public DbSet<HastaBilgileri> HastaBilgileris { get; set; }
        public DbSet<HastaRaporlari> hastaRaporlaris {  get; set; } 
        public DbSet<MuayeneBilgileri> muayeneBilgileris { get; set; }
        public DbSet<IlacBilgileri> ılacBilgileris { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                  .HasRequired(a => a.Yetkilendirme)
                  .WithMany()
                  .HasForeignKey(a => a.Yönetimid);


        }
        


    }
}