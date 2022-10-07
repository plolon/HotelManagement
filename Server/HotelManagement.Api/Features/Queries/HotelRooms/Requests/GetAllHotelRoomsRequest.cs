using HotelManagement.Api.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Api.Features.Queries.HotelRooms.Requests
{
    public class GetAllHotelRoomsRequest :IRequest<ICollection<HotelRoomDto>>
    {
    }
}