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
    internal class OgunDetayCFG : IEntityTypeConfiguration<OgunDetay>
    {
        public void Configure(EntityTypeBuilder<OgunDetay> builder)
        {
            builder.HasKey(od => od.ID);

            builder.Property(od => od.ID)
                   .HasColumnName("OgunDetayID");

        }
    }
}
