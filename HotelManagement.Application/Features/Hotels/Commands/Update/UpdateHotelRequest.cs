using HotelManagement.Application.Abstraction;
using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Requests
{
    public class UpdateHotelRequest : ICommand<HotelDto>
    {
        public SaveHotelDto UpdateHotelDto  {get; set;} 
        public int Id { get; set; }
    }
}
