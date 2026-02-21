using MediatR;

namespace BuildingBlocks.CQRS
{
    public interface ICommandhandler<in TCommand> : ICommandhandler<TCommand, Unit>
        where TCommand : ICommand<Unit>
    {
    }

    public interface ICommandhandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
        where TCommand : ICommand<TResponse> where TResponse : notnull
    {
    }
}
