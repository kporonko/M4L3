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
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee").HasKey(e => e.EmployeeId);
            builder.Property(p => p.EmployeeId).HasColumnName("EmployeeId").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.LastName).HasColumnName("LastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.HiredDate).HasColumnName("HiredDate").IsRequired().HasColumnType("datetime2").HasMaxLength(7);
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").HasColumnType("date");
            builder.Property(p => p.OfficeId).HasColumnName("OfficeId").HasColumnType("int");
            builder.Property(p => p.TitleId).HasColumnName("TitleId").HasColumnType("int");
        }
    }
}
