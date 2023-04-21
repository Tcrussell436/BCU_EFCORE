namespace BCU_EFCORE.Entities;

public class BCU_Account
{
    public int AccountNumber { get; set; }
    public string AccountType { get; set; }
    public decimal Balance { get; set; }
    public string DependentEmployeeNumber { get; set; }
    public string EmployeeNumber { get; set; }
    public string DependentFirstName { get; set; }
    public string DependentLastName { get; set; }
    
    public Dependent Dependent { get; set; }
    
    public Employee Employee { get; set; }
}