using HotelManagement.Application.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
    public class GetHotelRoomByIdRequest :IRequest<HotelRoomDto>
    {
        public int Id { get; set; }
    }
}