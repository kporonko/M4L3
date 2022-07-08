namespace OfficeEntity.Models
{
    public class Office
    {
        public int OfficeId { get; set; }
        public string Ttitle { get; set; } = null!;
        public string Location { get; set; } = null!;
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}