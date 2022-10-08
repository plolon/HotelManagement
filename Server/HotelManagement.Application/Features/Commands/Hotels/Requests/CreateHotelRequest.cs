using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Requests
{
    public class CreateHotelRequest :IRequest<HotelDto>
    {
        public SaveHotelDto SaveHotelDto { get; set; }
    }
}
