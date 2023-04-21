namespace BCU_EFCORE.Entities;

public class Dependent
{
    public string EmployeeNumber { get; set; }
    public string DependentFirstName { get; set; }
    public string DependentLastName { get; set; }
    public string Relationship { get; set; }
    public DateTime BirthDate { get; set; }
    public string Gender { get; set; }
    
    public Employee Employee { get; set; }
    public IEnumerable<BCU_Account> BcuAccount { get; set; }
    public IEnumerable<Participation> Participations { get; set; }
}