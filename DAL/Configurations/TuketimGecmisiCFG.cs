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
    internal class TuketimGecmisiCFG : IEntityTypeConfiguration<TuketimGecmisi>
    {
        public void Configure(EntityTypeBuilder<TuketimGecmisi> builder)
        {
            builder.HasKey(yy => yy.ID);

            builder.Property(yy => yy.ID)
                   .HasColumnName("TuketimGecmisiID");

            builder.Property(yy => yy.OgunID)
                   .HasColumnType("int");

            builder.Property(yy => yy.KategoriID)
                   .HasColumnType("int");

            builder.Property(yy => yy.YiyecekID)
                   .HasColumnType("int");
        }
    }
}
