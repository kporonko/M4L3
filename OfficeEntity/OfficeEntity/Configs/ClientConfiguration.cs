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

            builder.HasData(new List<Client>()
            {
                new Client() { ClientId = 1, FirstName = "First", LastName = "Firsty", Email = "first@gmail.com", BirthDate = new DateTime(2000, 11, 2) },
                new Client() { ClientId = 2, FirstName = "Second", LastName = "Secondy", Email = "2@gmail.com", BirthDate = new DateTime(2000, 11, 2) },
                new Client() { ClientId = 3, FirstName = "3", LastName = "3y", Email = "3@gmail.com", BirthDate = new DateTime(2000, 11, 2) },
                new Client() { ClientId = 4, FirstName = "4", LastName = "4y", Email = "4@gmail.com", BirthDate = new DateTime(2000, 11, 2) },
                new Client() { ClientId = 5, FirstName = "five", LastName = "5", Email = "5@gmail.com", BirthDate = new DateTime(2000, 11, 2) },
            });
        }
    }
}