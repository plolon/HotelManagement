using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Queries.Hotels.Requests
{
    public class GetHotelByIdRequest : IRequest<HotelDto>
    {
        public int Id { get; set; }
    }
}
