using EgitimYoklamaOtomasyonu.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EgitimYoklamaOtomasyonu.DAL.Context
{
    public class YoklamaContext : DbContext
    {
        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciGiris> KullaniciGirisler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Sube> Subeler { get; set; }
        public DbSet<SinifDersGun> SinifDersGunler { get; set; }
        public DbSet<OgrenciYoklama> OgrenciYoklamalar { get; set; }
        public DbSet<Yoklama> Yoklamalar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABDULKADIROZTUZ\SQLEXPRESS;Database=EgitimYoklamaOtomasyon;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sube>().HasData(
           new Sube
           {
               Adi = "",
               Adres = "",
               Id = 1,
               Mail = "",
               Telefon = ""
           });

            modelBuilder.Entity<Kullanici>().HasData(
             new Kullanici
             {
                 Id = -1,
                 Adi = "admin",
                 SoyAdi = "admin",
                 Telefon = "000",
                 KullaniciTipi = Data.Entities.Enums.KullaniciTipi.Yonetici,
                 Mail = "admin",
                 Parola = "admin",
                 SubeID = 1

             },
             new Kullanici
             {
                 Id = -2,
                 Adi = "k",
                 SoyAdi = "k",
                 Telefon = "000",
                 KullaniciTipi = Data.Entities.Enums.KullaniciTipi.Koordinator,
                 Mail = "k",
                 Parola = "k",
                 SubeID = 1

             },
              new Kullanici
              {
                  Id = -3,
                  Adi = "e",
                  SoyAdi = "e",
                  Telefon = "000",
                  KullaniciTipi = Data.Entities.Enums.KullaniciTipi.Egitmen,
                  Mail = "e",
                  Parola = "e",
                  SubeID = 1
              }
             );

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
