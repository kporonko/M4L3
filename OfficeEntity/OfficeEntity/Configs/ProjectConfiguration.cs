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
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.Budget).IsRequired().HasColumnName("Budget").HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(p => p.Description).IsRequired().HasColumnName("Description").HasColumnType("nvarchar");
        }
    }
}
