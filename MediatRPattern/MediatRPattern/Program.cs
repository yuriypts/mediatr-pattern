using MediatRPattern.ManagerStructure;
using MediatRPattern.MediatorStructure;

namespace MediatRPattern;

public class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new();

        BackendDeveloper backendDeveloper = new(mediator);
        FrontendDeveloper frontendDeveloper = new(mediator);
        QA qa = new(mediator);

        mediator.BackendDeveloper = backendDeveloper;
        mediator.FrontendDeveloper = frontendDeveloper;
        mediator.QA = qa;

        Console.WriteLine("Backend Developer Started Work");

        backendDeveloper.Develop("Backend Developer End Work");

        Console.WriteLine("Hello, World!");
    }
}
