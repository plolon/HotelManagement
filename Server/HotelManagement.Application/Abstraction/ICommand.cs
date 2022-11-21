using MediatR;

namespace HotelManagement.Application.Abstraction
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {
        
    }
}