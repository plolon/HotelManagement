using HotelManagement.Application.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Application.Features.Queries.HotelRooms.Requests
{
    public class GetAllHotelRoomsRequest :IRequest<ICollection<HotelRoomDto>>
    {
    }
}