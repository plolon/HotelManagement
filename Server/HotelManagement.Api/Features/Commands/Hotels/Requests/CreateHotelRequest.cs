using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Requests
{
    public class CreateHotelRequest :IRequest<HotelDto>
    {
        public SaveHotelDto SaveHotelDto { get; set; }
    }
}
