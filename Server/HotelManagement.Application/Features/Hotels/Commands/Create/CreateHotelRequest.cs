using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.Hotel;

namespace HotelManagement.Application.Features.Commands.Hotels.Requests
{
    public class CreateHotelRequest :ICommand<HotelDto>
    {
        public SaveHotelDto SaveHotelDto { get; set; }
    }
}
