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
    internal class YiyecekDetayCFG : IEntityTypeConfiguration<YiyecekDetay>
    {
        public void Configure(EntityTypeBuilder<YiyecekDetay> builder)
        {
            builder.HasKey(yd => yd.ID);

            builder.Property(yd => yd.ID)
                   .HasColumnName("YiyecekDetayID");

            builder.Property(yd => yd.Icerik)
                   .HasColumnType("varchar")
                   .HasMaxLength(100);

            builder.Property(yd => yd.Kalori100gr)
                   .HasColumnType("float");

            builder.Property(yd => yd.Protein100gr)
                   .HasColumnType("float");

            builder.Property(yd => yd.Karbonhidrat100gr)
                   .HasColumnType("float");

            builder.Property(yd => yd.Yag100gr)
                   .HasColumnType("float");

            builder.HasOne(yd => yd.Yiyecek)
                   .WithMany(yd => yd.YiyecekDetaylari)
                   .OnDelete(DeleteBehavior.NoAction);



            builder.HasData(
                new YiyecekDetay { ID = 1, Icerik = "dana Eti", Kalori100gr = 250, Protein100gr = 26, Karbonhidrat100gr = 0, Yag100gr = 17, YiyecekID = 1 },

                new YiyecekDetay { ID = 2, Icerik = "Tavuk Eti", Kalori100gr = 165, Protein100gr = 31, Karbonhidrat100gr = 0, Yag100gr = 3.6, YiyecekID = 2 },

                new YiyecekDetay { ID = 3, Icerik = "Balık Eti", Kalori100gr = 208, Protein100gr = 16, Karbonhidrat100gr = 0, Yag100gr = 15, YiyecekID = 3 },

                new YiyecekDetay { ID = 4, Icerik = "%70 inek sütü", Kalori100gr = 300, Protein100gr = 20, Karbonhidrat100gr = 5, Yag100gr = 30, YiyecekID = 4 },

                new YiyecekDetay { ID = 5, Icerik = "Anne eli değimiş gibi", Kalori100gr = 536, Protein100gr = 6.6, Karbonhidrat100gr = 51, Yag100gr = 34, YiyecekID = 5 },

                new YiyecekDetay { ID = 6, Icerik = "newton hatrına", Kalori100gr = 52, Protein100gr = 0.3, Karbonhidrat100gr = 14, Yag100gr = 0.2, YiyecekID = 6 }
                );
        }
    }
}
