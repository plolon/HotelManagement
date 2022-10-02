using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Requests
{
    public class UpdateHotelRequest : IRequest<HotelDto>
    {
        public SaveHotelDto UpdateHotelDto  {get; set;} 
        public int Id { get; set; }
    }
}
