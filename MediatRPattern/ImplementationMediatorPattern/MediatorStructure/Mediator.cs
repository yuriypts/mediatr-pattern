namespace ImplementationMediatorPattern.MediatorStructure;

public class Mediator : IMediator
{
    private readonly Dictionary<Type, object> _handlers = new();

    public void Register<TRequest, TResponse>(IRequestHandler<TRequest, TResponse> requestHandler) where TRequest : IRequest<TResponse>
    {
        _handlers.Add(typeof(TRequest), requestHandler);
    }

    public TResponse Send<TRequest, TResponse>(TRequest request) where TRequest : IRequest<TResponse>
    {
        if (_handlers.TryGetValue(typeof(TRequest), out var handlerObj))
        {
            var handler = (IRequestHandler<TRequest, TResponse>)handlerObj;
            return handler.Handle(request);
        }

        throw new ArgumentException($"No handler registered for {typeof(TRequest)}");
    }
}
