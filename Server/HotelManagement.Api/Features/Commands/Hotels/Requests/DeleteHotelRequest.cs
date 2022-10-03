using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Requests
{
    public class DeleteHotelRequest : IRequest<bool>
    {
        public int Id { get; set; }
    }
}