namespace ImplementationMediatorPattern.MediatorStructure;

public interface IMediator
{
    TResponse Send<TRequest, TResponse>(TRequest request) where TRequest : IRequest;
}
