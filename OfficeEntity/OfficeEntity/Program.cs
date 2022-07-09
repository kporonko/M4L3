using OfficeEntity.Data;
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    context.SaveChanges();
}

Console.WriteLine("Hello, World!");