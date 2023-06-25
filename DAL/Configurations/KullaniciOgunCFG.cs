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
    public class KullaniciOgunCFG : IEntityTypeConfiguration<KullaniciOgun>
    {
        public void Configure(EntityTypeBuilder<KullaniciOgun> builder)
        {
            builder.HasKey(ko => ko.ID);

            builder.Property(ko => ko.ID)
                   .HasColumnName("KullaniciOgunID");
        }
    }
}
