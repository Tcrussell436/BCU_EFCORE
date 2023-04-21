namespace BCU_EFCORE.Entities;

public class Manager
{
    public string ManagerNumber { get; set; }
    public DateTime ManagerStartDate { get; set; }

    public Employee Employee { get; set; }
    public Plant Plant { get; set; }
}