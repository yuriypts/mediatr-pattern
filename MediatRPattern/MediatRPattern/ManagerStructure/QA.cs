using MediatRPattern.MediatorStructure;

namespace MediatRPattern.ManagerStructure;

public class QA : Manager
{
    public QA(AbstractMediator mediator) : base(mediator)
    {
    }

    public void Test(string msg)
    {
        Console.WriteLine(msg);

        _mediator.Send(msg, this);
    }
}
