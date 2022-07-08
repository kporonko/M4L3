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
            ConnectionString connectionString = new ConnectionString();
            Services services = new Services();
            connectionString = services.Deserialization();
            var optionsBuilder = new DbContextOptionsBuilder<OfficeEntityContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString.DbConnectionString)
                .Options;

            return new OfficeEntityContext(options);
        }
    }
}
