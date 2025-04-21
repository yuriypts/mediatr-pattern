using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.ManagerStructure;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern;

internal class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new();

        mediator.Register<WorkerQuery, Worker>(new WorkerHandler());

        List<WorkerQuery> developerQueries = new()
        {
            new WorkerQuery(1, "BackendDeveloper"),
            new WorkerQuery(2, "FrontendDeveloper"),
            new WorkerQuery(3, "QA")
        };

        foreach (WorkerQuery developerQuery in developerQueries)
        {
            Worker response = mediator.Send<WorkerQuery, Worker>(developerQuery);
            Console.WriteLine("Id - {0}, Name - {1}", response.Id, response.Name);
        }

        Console.WriteLine("Hello, World!");
    }
}
