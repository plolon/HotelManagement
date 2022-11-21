using MediatR;

namespace HotelManagement.Application.Abstraction
{
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
    where TCommand : class, ICommand<TResponse>
    {
    }
}