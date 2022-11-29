using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Queries.Hotels.Requests
{
    public class GetAllHotelsRequest :IRequest<ICollection<HotelDto>>
    {
    }
}
