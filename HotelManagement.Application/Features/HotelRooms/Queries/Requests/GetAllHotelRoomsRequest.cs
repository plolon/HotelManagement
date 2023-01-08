using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.HotelRoom;

namespace HotelManagement.Application.Features.Queries.HotelRooms.Requests
{
    public class GetAllHotelRoomsRequest : IQuery<ICollection<HotelRoomDto>>
    {
    }
}