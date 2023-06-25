using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class KategoriCFG : IEntityTypeConfiguration<Kategori>
    {
        public void Configure(EntityTypeBuilder<Kategori> builder)
        {
            builder.HasKey(k => k.ID);

            builder.Property(k => k.ID)
                   .HasColumnName("KategoriID");

            builder.Property(k => k.KategoriAd)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.HasData(
                new Kategori { ID = 1, KategoriAd = "Kirmizi Et" },
                new Kategori { ID = 2, KategoriAd = "Beyaz Et" },
                new Kategori { ID = 3, KategoriAd = "Deniz Urunleri" },
                new Kategori { ID = 4, KategoriAd = "Sut ve Sut Urunleri" },
                new Kategori { ID = 5, KategoriAd = "Atistirmalik" },
                new Kategori { ID = 6, KategoriAd = "Meyve/Sebze" },
                new Kategori { ID = 7, KategoriAd = "Temel Gida" }
                );
        }
    }
}
