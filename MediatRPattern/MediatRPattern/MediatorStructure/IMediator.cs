using MediatRPattern.ManagerStructure;

namespace MediatRPattern.MediatorStructure;

//public interface IMediator
//{
//    void Send(string msg, Manager manager);
//}

public abstract class AbstractMediator
{
    public abstract void Send(string msg, Manager manager);
}
