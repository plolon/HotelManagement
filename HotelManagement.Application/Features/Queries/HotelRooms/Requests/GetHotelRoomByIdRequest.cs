using HotelManagement.Application.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Application.Features.Queries.HotelRooms.Requests
{
    public class GetHotelRoomByIdRequest :IRequest<HotelRoomDto>
    {
        public int Id { get; set; }
    }
}