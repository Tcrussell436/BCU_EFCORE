namespace BCU_EFCORE.Entities;

public class Participation
{
    public string HobbyName { get; set; }
    public string DependentEmployeeNumber { get; set; }
    public string DependentFirstName { get; set; }
    public string DependentLastName { get; set; }
    public decimal AnnualCost { get; set; }
    public decimal HoursPerWeek { get; set; }

    public Hobby Hobby { get; set; }
    public Dependent Dependent { get; set; }
}