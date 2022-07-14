using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OfficeEntity.Models;

namespace OfficeEntity.Configs
{
    public class OfficeConfiguration : IEntityTypeConfiguration<Office>
    {
        public void Configure(EntityTypeBuilder<Office> builder)
        {
            builder.ToTable("Office").HasKey(o => o.OfficeId);
            builder.Property(e => e.OfficeId).ValueGeneratedOnAdd();
            builder.Property(p => p.Ttitle).IsRequired().HasColumnName("Ttitle").HasColumnType("nvarchar").HasMaxLength(100);
            builder.Property(p => p.Location).IsRequired().HasColumnName("Location").HasColumnType("nvarchar").HasMaxLength(100);
        }
    }
}
