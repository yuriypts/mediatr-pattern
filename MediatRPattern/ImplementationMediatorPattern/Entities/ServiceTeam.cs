namespace ImplementationMediatorPattern.Entities;

public class ServiceTeam
{
    public int Id { get; set; }
    public Action<int> Action { get; set; }
}
