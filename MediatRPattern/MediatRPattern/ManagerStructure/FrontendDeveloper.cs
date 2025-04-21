using MediatRPattern.MediatorStructure;

namespace MediatRPattern.ManagerStructure;

public class FrontendDeveloper : Manager
{
    public FrontendDeveloper(AbstractMediator mediator) : base(mediator)
    {
    }

    public void Develop(string msg)
    {
        Console.WriteLine(msg);

        _mediator.Send(msg, this);
    }
}
