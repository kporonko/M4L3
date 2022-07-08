using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OfficeEntity.Configs;
using OfficeEntity.Models;

namespace OfficeEntity.Data
{
    public class OfficeEntityContext : DbContext
    {
        public OfficeEntityContext(DbContextOptions<OfficeEntityContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());

            modelBuilder.Entity<Employee>().HasOne(p => p.Office).WithMany(t => t.Employees).HasForeignKey(p => p.OfficeId);
            modelBuilder.Entity<Employee>().HasOne(p => p.Title).WithMany(p => p.Employees).HasForeignKey(p => p.TitleId);
            modelBuilder.Entity<EmployeeProject>().HasOne(p => p.Employee).WithMany(t => t.EmployeeProjects).HasForeignKey(p => p.EmployeeId);
            modelBuilder.Entity<EmployeeProject>().HasOne(p => p.Project).WithMany(t => t.EmployeeProjects).HasForeignKey(p => p.ProjectId);
        }
    }
}
