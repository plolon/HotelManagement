using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Requests
{
    public class DeleteHotelRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}