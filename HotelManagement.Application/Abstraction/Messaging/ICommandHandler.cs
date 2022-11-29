using MediatR;

namespace HotelManagement.Application.Abstraction.Messaging
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : class, ICommand<TResponse>
    {
    }
}