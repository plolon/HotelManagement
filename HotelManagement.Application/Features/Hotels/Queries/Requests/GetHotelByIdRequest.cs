using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Hotels.Queries.Requests
{
    public class GetHotelByIdRequest : IRequest<HotelDto>
    {
        public int Id { get; set; }
    }
}
