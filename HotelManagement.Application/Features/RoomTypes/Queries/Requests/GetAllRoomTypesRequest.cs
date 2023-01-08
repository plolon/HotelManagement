using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.RoomType;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
    public class GetAllRoomTypesRequest : IQuery<ICollection<RoomTypeDto>>
    {

    }
}