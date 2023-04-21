namespace BCU_EFCORE.Entities;

public class Employee
{
    public string EmployeeNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StreetLine1 { get; set; }
    public string StreetLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Postal { get; set; }
    public string Gender { get; set; }
    public DateTime DateHired { get; set; }
    public decimal Salary { get; set; }
    public string SupervisorNumber { get; set; }
    public int PlantNumber { get; set; }
    
    public Employee Supervisor { get; set; }
    public Plant Plant { get; set; }
    public IEnumerable<BCU_Account> BcuAccount { get; set; }
    public IEnumerable<Dependent> Dependents { get; set; }
    public IEnumerable<Job> Jobs { get; set; }
}