using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern.ManagerStructure;

public class WorkerQuery : IRequest
{
    public int Id { get; }
    public string Name { get; set; }

    public WorkerQuery(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
