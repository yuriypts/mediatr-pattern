using ImplementationMediatorPattern.Entities;
using ImplementationMediatorPattern.ManagerStructure;
using ImplementationMediatorPattern.MediatorStructure;
using System.Reflection;

namespace ImplementationMediatorPattern;

internal class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new();

        mediator.Register<WorkerQuery, Worker>(new WorkerHandler());
        mediator.Register<ServiceQuery, ServiceTeam>(new ServiceHandler());

        List<IRequest> queries = new()
        {
            new WorkerQuery(1, "BackendDeveloper"),
            new WorkerQuery(2, "FrontendDeveloper"),
            new WorkerQuery(3, "QA"),
            new ServiceQuery(4, ShowMessage),
            new ServiceQuery(5, (int id) => Console.WriteLine("Show Id - {0}", id)),
        };

        foreach (IRequest query in queries)
        {
            object response = null;

            if (query is WorkerQuery)
                response = mediator.Send<WorkerQuery, Worker>((query as WorkerQuery)!);
            else if (query is ServiceQuery)
                response = mediator.Send<ServiceQuery, ServiceTeam>((query as ServiceQuery)!);

            Type type = response.GetType();
            PropertyInfo propertyInfo = type.GetProperty("Id")!; 

            Console.WriteLine("Id - {0}", propertyInfo.GetValue(response));
        }

        //List<ServiceQuery> serviceQueries = new()
        //{
        //    new ServiceQuery(1, ShowMessage),
        //    new ServiceQuery(2, (int id) => Console.WriteLine("Show Id - {0}", id)),
        //};

        //foreach (ServiceQuery query in serviceQueries)
        //{
        //    ServiceTeam response = mediator.Send<ServiceQuery, ServiceTeam>(query);
        //    Console.WriteLine("Id - {0}", response.Id);
        //}

        //ServiceTeam serviceResponse = mediator.Send<ServiceQuery, ServiceTeam>(new ServiceQuery(1, ShowMessage));
        //Console.WriteLine("Id - {0}", serviceResponse.Id);

        //Console.WriteLine("Hello, World!");
    }

    public static void ShowMessage(int id)
    {
        Console.WriteLine("Show Id - {0}", id);
    }
}
