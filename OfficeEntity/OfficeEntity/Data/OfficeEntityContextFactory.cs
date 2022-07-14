using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace OfficeEntity.Data
{
    public sealed class OfficeEntityContextFactory : IDesignTimeDbContextFactory<OfficeEntityContext>
    {
        public OfficeEntityContext CreateDbContext(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=OfficeDb;Integrated Security=True;";
            var optionsBuilder = new DbContextOptionsBuilder<OfficeEntityContext>();
            var options = optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(connectionString)
                .Options;

            return new OfficeEntityContext(options);
        }
    }
}
