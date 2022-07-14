namespace OfficeEntity.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedDate { get; set; }
        public virtual List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public string Description { get; set; }
    }
}