using HotelManagement.Api.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Requests
{
    public class GetAllHotelsRequest :IRequest<ICollection<HotelDto>>
    {
    }
}
