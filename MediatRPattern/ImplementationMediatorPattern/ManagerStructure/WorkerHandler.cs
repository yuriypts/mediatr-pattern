using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class WorkerHandler : IRequestHandler<WorkerQuery, Worker>
{
    public Worker Handle(WorkerQuery request)
    {
        return new Worker
        {
            Id = request.Id,
            Name = request.Name
        };
    }
}
