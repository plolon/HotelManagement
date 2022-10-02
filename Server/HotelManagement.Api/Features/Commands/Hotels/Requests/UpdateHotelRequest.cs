using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Commands.Hotels.Requests
{
    public class UpdateHotelRequest : IRequest<HotelDto>
    {
        public HotelDto UpdateHotelDto  {get; set;} 
    }
}