using HotelManagement.Application.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
    public class GetHotelRoomByIdRequest :IRequest<HotelRoomDto>
    {
        public int Id { get; set; }
    }
}