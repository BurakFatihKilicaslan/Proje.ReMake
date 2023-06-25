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
    internal class BesinDegeriCFG : IEntityTypeConfiguration<BesinDegeri>
    {
        public void Configure(EntityTypeBuilder<BesinDegeri> builder)
        {
            builder.HasKey(bd => bd.ID);

            builder.Property(bd => bd.ID)
                   .HasColumnName("BesinDegeriID");

            builder.Property(bd => bd.PorsiyonGramaji)
                   .HasColumnType("float");

            builder.Property(bd => bd.Kalori)
                   .HasColumnType("float");

            builder.Property(bd => bd.Protein)
                   .HasColumnType("float");

            builder.Property(bd => bd.Karbonhidrat)
                   .HasColumnType("float");

            builder.Property(bd => bd.Yag)
                   .HasColumnType("float");
        }
    }
}
