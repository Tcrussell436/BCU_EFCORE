namespace BCU_EFCORE.Entities;

public class Project
{
    public int ProjectNumber { get; set; }
    public string ProjectName { get; set; }
    public string Location { get; set; }
    public int PlantNumber { get; set; }

    public Plant Plant { get; set; }
    public IEnumerable<Job> Jobs { get; set; }
}