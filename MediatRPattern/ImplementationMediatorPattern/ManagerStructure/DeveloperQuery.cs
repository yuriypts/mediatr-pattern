using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class DeveloperQuery : IRequest<Developer>
{
    public int Id { get; }
    public string Name { get; set; }

    public DeveloperQuery(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
