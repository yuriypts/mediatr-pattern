using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class ServiceQuery : IRequest
{
    public int Id { get; }
    public Action<int> Action { get; set; }

    public ServiceQuery(int id, Action<int> action)
    {
        Id = id;
        Action = action;
    }
}
