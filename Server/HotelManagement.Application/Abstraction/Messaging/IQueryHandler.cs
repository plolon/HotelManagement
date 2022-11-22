using MediatR;

namespace HotelManagement.Application.Abstraction.Messaging
{
    public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
        where TQuery : class, IQuery<TResponse>
    {
    }
}