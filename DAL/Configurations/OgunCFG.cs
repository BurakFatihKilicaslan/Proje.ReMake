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
    internal class OgunCFG : IEntityTypeConfiguration<Ogun>
    {
        public void Configure(EntityTypeBuilder<Ogun> builder)
        {
            builder.HasKey(o => o.ID);

            builder.Property(o => o.ID)
                   .HasColumnName("OgunID");

            builder.Property(o => o.OgunAd)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.HasMany(o => o.YiyecekOgunleri)
                   .WithOne(o => o.Ogun)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasData(
                new Ogun { ID = 1, OgunAd = "Sabah" },
                new Ogun { ID = 2, OgunAd = "Ogle" },
                new Ogun { ID = 3, OgunAd = "Aksam" },
                new Ogun { ID = 4, OgunAd = "Ara" }
                );
        }
    }
}
