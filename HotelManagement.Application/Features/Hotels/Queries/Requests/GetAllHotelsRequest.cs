using HotelManagement.Application.DTOs.Hotel;
using MediatR;

namespace HotelManagement.Application.Features.Hotels.Queries.Requests
{
    public class GetAllHotelsRequest :IRequest<ICollection<HotelDto>>
    {
    }
}
