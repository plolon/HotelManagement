using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Hotel;

namespace HotelManagement.Application.Features.Hotels.Queries.Requests
{
    public class GetAllHotelsRequest : IQuery<ICollection<HotelDto>>
    {
    }
}
