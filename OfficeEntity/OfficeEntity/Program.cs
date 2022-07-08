using OfficeEntity.Data;
OfficeEntityContextFactory officeEntityContextFactory = new OfficeEntityContextFactory();
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    context.Database.EnsureCreated();
}

Console.WriteLine("Hello, World!");
