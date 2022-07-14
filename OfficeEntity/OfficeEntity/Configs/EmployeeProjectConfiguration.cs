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
    public class EmployeeProjectConfiguration : IEntityTypeConfiguration<EmployeeProject>
    {
        public void Configure(EntityTypeBuilder<EmployeeProject> builder)
        {
            builder.ToTable("EmployeeProject").HasKey(e => e.EmployeeProjectId);
            builder.Property(e => e.EmployeeProjectId).ValueGeneratedOnAdd();
            builder.Property(p => p.EmployeeId).IsRequired().HasColumnName("EmployeeId").HasColumnType("int");
            builder.Property(p => p.ProjectId).HasColumnName("ProjectId").IsRequired().HasColumnType("int");
            builder.Property(p => p.Rate).HasColumnName("Rate").IsRequired().HasColumnType("money");
            builder.Property(p => p.StartedDate).IsRequired().HasColumnName("StartedDate").HasColumnType("datetime2").HasMaxLength(7);
        }
    }
}
