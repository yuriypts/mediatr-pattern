using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class ServiceHandler : IRequestHandler<ServiceQuery, ServiceTeam>
{
    public ServiceTeam Handle(ServiceQuery request)
    {
        request.Action(request.Id);

        return new ServiceTeam
        {
            Id = request.Id,
            Action = request.Action
        };
    }
}
