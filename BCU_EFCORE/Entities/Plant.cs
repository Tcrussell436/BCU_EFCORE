namespace BCU_EFCORE.Entities;

public class Plant
{
    public int PlantNumber { get; set; }
    public string PlantName { get; set; }
    public decimal Budget { get; set; }
    public string ManagerNumber { get; set; }

    public Manager Manager { get; set; }
    public IEnumerable<Project> Projects { get; set; }
    public IEnumerable<Building> Buildings { get; set; }
    public IEnumerable<Employee> Employees { get; set; }
}