using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Hotel;

namespace HotelManagement.Application.Features.Hotels.Queries.Requests
{
    public class GetHotelByIdRequest : IQuery<HotelDto>
    {
        public int Id { get; set; }
    }
}
