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

        mediator.Send("Backend Developer", backendDeveloper);
        mediator.Send("Backend Developer", frontendDeveloper);
        mediator.Send("QA", qa);

        Console.WriteLine("Hello, World!");
    }
}
