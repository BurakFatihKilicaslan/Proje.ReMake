using DAL.Configurations;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class HubDbContext : DbContext
    {
        public DbSet<AktiviteSeviyesi> AktiviteSeviyeleri { get; set; }
        public DbSet<BesinDegeri> BesinDegerleri { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<YiyecekOgun> YiyecekOgunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<KullaniciGecmisi> KullaniciGecmisleri { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<OgunDetay> OgunDetaylari { get; set; }
        public DbSet<GunlukRapor> GunlukRaporlar { get; set; }
        public DbSet<TuketimGecmisi> TuketimGecmisleri { get; set; }
        public DbSet<Yiyecek> Yiyecekler { get; set; }
        public DbSet<YiyecekDetay> YiyecekDetaylari { get; set; }
        public DbSet<KullaniciOgun> KullaniciOgunleri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HUBDB12;Integrated Security=True");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AktiviteSeviyesiCFG());
            modelBuilder.ApplyConfiguration(new BesinDegeriCFG());
            modelBuilder.ApplyConfiguration(new KategoriCFG());
            modelBuilder.ApplyConfiguration(new YiyecekOgunCFG());
            modelBuilder.ApplyConfiguration(new KullaniciCFG());
            modelBuilder.ApplyConfiguration(new KullaniciGecmisiCFG());
            modelBuilder.ApplyConfiguration(new OgunCFG());
            modelBuilder.ApplyConfiguration(new OgunDetayCFG());
            modelBuilder.ApplyConfiguration(new GunlukRaporCFG());
            modelBuilder.ApplyConfiguration(new TuketimGecmisiCFG());
            modelBuilder.ApplyConfiguration(new YiyecekCFG());
            modelBuilder.ApplyConfiguration(new YiyecekDetayCFG());
            modelBuilder.ApplyConfiguration(new KullaniciOgunCFG());
        }
    }
}
