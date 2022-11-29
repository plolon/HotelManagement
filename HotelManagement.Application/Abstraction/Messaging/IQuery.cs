using MediatR;

namespace HotelManagement.Application.Abstraction.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
        
    }
}