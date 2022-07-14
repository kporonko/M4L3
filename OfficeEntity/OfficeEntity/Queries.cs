using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeEntity.Data;
using OfficeEntity.Models;

namespace OfficeEntity
{
    public class Queries
    {
        public double DateDiff(Employee employee)
        {
            return (DateTime.Now - employee.HiredDate).TotalDays;
        }

        public void UpdateTwoEntities(OfficeEntityContext context, ref Employee employee1, ref Employee employee2)
        {
            Console.WriteLine("Before update:\n" + employee1.FirstName + "\n" + employee2.FirstName);
            employee1.FirstName = "Vasya";
            employee2.FirstName = "Vova";
            context.UpdateRange(employee1, employee2);
            context.SaveChanges();
            Console.WriteLine("After update:\n" + employee1.FirstName + "\n" + employee2.FirstName);
        }

        public void AddEmployee(OfficeEntityContext context)
        {
            var empProj = new EmployeeProject { ProjectId = 16, Rate = 1000, StartedDate = DateTime.Now };
            var title = new Title { Name = "NewTitle" };
            context.Add(new Employee
            {
                HiredDate = DateTime.Now,
                DateOfBirth = new DateTime(2000, 2, 2),
                FirstName = "Random",
                LastName = "Random",
                Title = title,
                EmployeeProjects = new List<EmployeeProject> { empProj },
                OfficeId = 1
            });
            context.SaveChanges();
        }

        public void DeleteEmployee(OfficeEntityContext context, int id)
        {
            var employee = context.Employees.Where(i => i.EmployeeId == id).FirstOrDefault();
            try
            {
                context.Remove(employee);
                context.SaveChanges();
            }
            catch (Exception)
            {
                Console.WriteLine("There is no such an employee");
            }
        }

        public void Grouping(OfficeEntityContext context)
        {
            var res = context.Employees
                .GroupBy(i => i.Title)
                .Where(t => !t.Key.Name.Contains('a'))
                .Select(i => i.Key.Name);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }

        public void SelectingJoinedEntities(OfficeEntityContext context)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in context.Employees)
            {
                stringBuilder.AppendLine(
                    $"Id: {item.EmployeeId}" +
                    $"\nName: {item.FirstName} {item.LastName}" +
                    $"\n Birth Date: {item.DateOfBirth}" +
                    $"\n Office: {item.Office.OfficeId}" +
                    $"\nOffice Location: {item.Office.Location}");
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
