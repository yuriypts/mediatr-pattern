using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class DeveloperQuery : IRequest
{
    public int Id { get; }
    public string Name { get; set; }

    public DeveloperQuery(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
