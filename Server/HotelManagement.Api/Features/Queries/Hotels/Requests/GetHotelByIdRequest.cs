using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Requests
{
    public class GetHotelByIdRequest : IRequest<HotelDto>
    {
        public int Id { get; set; }
    }
}
