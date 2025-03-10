using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.ManagerStructure;
using ImplementationMediatorPattern.MediatorStructure;

namespace ImplementationMediatorPattern;

internal class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new();

        mediator.Register<DeveloperQuery, Developer>(new DeveloperHandler());

        List<DeveloperQuery> developerQueries = new()
        {
            new DeveloperQuery(1, "BackendDeveloper"),
            new DeveloperQuery(2, "FrontendDeveloper"),
            new DeveloperQuery(3, "QA")
        };

        foreach (DeveloperQuery developerQuery in developerQueries)
        {
            Developer response = mediator.Send<DeveloperQuery, Developer>(developerQuery);
            Console.WriteLine("Id - {0}, Name - {1}", response.Id, response.Name);
        }

        Console.WriteLine("Hello, World!");
    }
}
