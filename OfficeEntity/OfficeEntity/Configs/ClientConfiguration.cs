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
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client").HasKey(e => e.ClientId);
            builder.Property(p => p.ClientId).HasColumnName("ClientId").ValueGeneratedOnAdd();
            builder.Property(p => p.FirstName).HasColumnName("FirstName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.LastName).HasColumnName("LastName").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.Email).HasColumnName("Email").IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            builder.Property(p => p.BirthDate).HasColumnName("BirthDate").HasColumnType("date");
        }
    }
}