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
    internal class AktiviteSeviyesiCFG : IEntityTypeConfiguration<AktiviteSeviyesi>
    {
        public void Configure(EntityTypeBuilder<AktiviteSeviyesi> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                   .HasColumnName("AktiviteSeviyesiID");

            builder.Property(a => a.SeviyeBilgisi)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(a => a.SeviyeDegeri)
                   .HasColumnType("float");

            builder.HasData(
                new AktiviteSeviyesi { ID = 1, SeviyeBilgisi = "Hareketsiz", SeviyeDegeri = 1.2 },
                new AktiviteSeviyesi { ID = 2, SeviyeBilgisi = "Dusuk Duzey", SeviyeDegeri = 1.375 },
                new AktiviteSeviyesi { ID = 3, SeviyeBilgisi = "Orta Duzey", SeviyeDegeri = 1.55 },
                new AktiviteSeviyesi { ID = 4, SeviyeBilgisi = "Yuksek Duzey", SeviyeDegeri = 1.725 },
                new AktiviteSeviyesi { ID = 5, SeviyeBilgisi = "Cok Yuksek Duzey", SeviyeDegeri = 1.9 }
                );
        }
    }
}
