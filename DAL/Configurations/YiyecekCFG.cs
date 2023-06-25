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
    internal class YiyecekCFG : IEntityTypeConfiguration<Yiyecek>
    {
        public void Configure(EntityTypeBuilder<Yiyecek> builder)
        {
            builder.HasKey(y => y.ID);

            builder.Property(y => y.ID)
                   .HasColumnName("YiyecekID");

            builder.Property(y => y.YiyecekAd)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.HasIndex(y => y.YiyecekAd)                      //Sonradan eklendi
                   .IsUnique();

            builder.HasMany(y => y.YiyecekDetaylari)
                   .WithOne(y => y.Yiyecek)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Yiyecek { ID = 1, YiyecekAd = "Bonfile", KategoriID = 1},
                new Yiyecek { ID = 2, YiyecekAd = "Firinda Tavuk", KategoriID = 2},
                new Yiyecek { ID = 3, YiyecekAd = "Hamsi Tava", KategoriID = 3},
                new Yiyecek { ID = 4, YiyecekAd = "Peynir", KategoriID = 4},
                new Yiyecek { ID = 5, YiyecekAd = "Cips", KategoriID = 5},
                new Yiyecek { ID = 6, YiyecekAd = "Elma", KategoriID = 6}
            );
        }
    }
}
