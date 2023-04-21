namespace BCU_EFCORE.Entities;

public class Job
{
    public string EmployeeNumber { get; set; }
    public int ProjectNumber { get; set; }
    
    public Employee Employee { get; set; }
    public Project Project { get; set; }
}