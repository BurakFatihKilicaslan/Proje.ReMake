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
    internal class GunlukRaporCFG : IEntityTypeConfiguration<GunlukRapor>
    {
        public void Configure(EntityTypeBuilder<GunlukRapor> builder)
        {
            builder.HasKey(td => td.ID);

            builder.Property(td => td.ID)
                   .HasColumnName("GunlukRaporID");

            builder.Property(td => td.KaloriIhtiyaci)
                   .HasColumnType("float");

            builder.Property(td => td.TuketilenKalori)
                   .HasColumnType("float");

            builder.Property(td => td.Protein)
                   .HasColumnType("float");

            builder.Property(td => td.Karbonhidrat)
                   .HasColumnType("float");

            builder.Property(td => td.Yag)
                   .HasColumnType("float");
        }
    }
}
