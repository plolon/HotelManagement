using MediatR;

namespace HotelManagement.Application.Abstraction
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
        //TODO Use in CQRS and add validators
    }
}