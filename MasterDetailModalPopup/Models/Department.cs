namespace MasterDetailModalPopup.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int NumberOfEmployees { get; set; }

        public virtual IList<Employee> Employees { get; set; } = new List<Employee>();
    }
}
