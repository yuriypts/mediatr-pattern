using MediatRPattern.MediatorStructure;

namespace MediatRPattern.ManagerStructure;

public class BackendDeveloper : Manager
{
    public BackendDeveloper(AbstractMediator mediator) : base(mediator)
    {
    }

    public void Develop(string msg)
    {
        Console.WriteLine(msg);

        _mediator.Send(msg, this);
    }
}
