namespace BCU_EFCORE.Entities;

public class Hobby
{
    public string HobbyName { get; set; }
    public string Activity { get; set; }

    public IEnumerable<Participation> Participations { get; set; }
}