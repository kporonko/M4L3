using OfficeEntity;
using OfficeEntity.Data;

Queries queries = new Queries();

// 1 Запрос, который возвращает разницу между CreatedDate/HiredDate и сегодня. Фильтрация должна быть выполнена на SQL сервере.
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    foreach (var employee in context.Employees)
    {
        Console.WriteLine(employee.EmployeeId + ": " + queries.DateDiff(employee));
    }
}

// 2 Запрос, который обновляет 2 сущности. Сделать в одной  транзакции.
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    var employee = context.Employees.Where(e => e.EmployeeId > 6).FirstOrDefault();
    var employee2 = context.Employees.Where(e => e.EmployeeId > 0).FirstOrDefault();
    queries.UpdateTwoEntities(context, ref employee, ref employee2);
}

// 3 Запрос, который добавляет сущность Employee с Title и Project.
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    queries.AddEmployee(context);
}

// 4 Запрос, который удаляет сущность Employee.
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    queries.DeleteEmployee(context, 21);
}

// 5 Запрос, который группирует сотрудников по ролям и возвращает название роли (Title) если оно не содержит ‘a’
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    queries.Grouping(context);
}

// 6 Запрос которые выводит в консоль данные из 2х связанных сущностей.
using (OfficeEntityContext context = new OfficeEntityContextFactory().CreateDbContext(Array.Empty<string>()))
{
    queries.SelectingJoinedEntities(context);
}
