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
            BackendDeveloper.Develop(msg);
        }
        else if (manager is FrontendDeveloper)
        {
            FrontendDeveloper.Develop(msg);
        }
        else if (manager is QA)
        {
            QA.Test(msg);
        }
        else
        {
            throw new ArgumentException("Invalid Manager");
        }
    }
}
