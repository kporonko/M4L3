using OfficeEntity.Data;
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    var clients = context.Clients.Where(c => c.ClientId >= 0);
    foreach (var client in clients)
    {
        Console.WriteLine(client.FirstName);
    }

    context.SaveChanges();
}

Console.WriteLine("Hello, World!");