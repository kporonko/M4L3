using OfficeEntity.Data;
OfficeEntityContextFactory officeEntityContextFactory = new OfficeEntityContextFactory();
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    context.Database.EnsureCreated();
    context.SaveChanges();
}

Console.WriteLine("Hello, World!");
