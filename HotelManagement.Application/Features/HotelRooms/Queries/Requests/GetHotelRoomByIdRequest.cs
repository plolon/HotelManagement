using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.HotelRoom;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
    public class GetHotelRoomByIdRequest : IQuery<HotelRoomDto>
    {
        public int Id { get; set; }
    }
}