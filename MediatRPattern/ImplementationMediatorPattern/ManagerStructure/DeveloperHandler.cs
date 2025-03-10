using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class DeveloperHandler : IRequestHandler<DeveloperQuery, Developer>
{
    public Developer Handle(DeveloperQuery request)
    {
        return new Developer
        {
            Id = request.Id,
            Name = request.Name
        };
    }
}
