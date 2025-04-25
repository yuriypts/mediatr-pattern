using MediatRPattern.ManagerStructure;

namespace MediatRPattern.MediatorStructure;

public class Mediator : AbstractMediator
{
    public BackendDeveloper BackendDeveloper { get; set; }
    public FrontendDeveloper FrontendDeveloper { get; set; }
    public QA QA { get; set; }

    public override void Send(string msg, Manager manager)
    {
        if (manager is BackendDeveloper)
        {
            Console.WriteLine("Frontend Developer Started Work");
            FrontendDeveloper.Develop("Fronted Developer End Work");
        }
        else if (manager is FrontendDeveloper)
        {
            Console.WriteLine("QA Started Work");
            QA.Test("QA End Work");
        }
        else if (manager is QA)
        {
            Console.WriteLine("QA - Done");
        }
    }
}
