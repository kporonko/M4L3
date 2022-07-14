namespace OfficeEntity.Models
{
    public class Title
    {
        public int TitleId { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
    }
}