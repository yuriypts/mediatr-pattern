namespace ImplementationMediatorPattern.MediatorStructure;

public interface IRequestHandler<TRequest, TResponse> where TRequest : IRequest
{
    TResponse Handle(TRequest request);
}
