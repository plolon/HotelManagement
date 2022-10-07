using HotelManagement.Api.DTOs.HotelRoom;
using MediatR;

namespace HotelManagement.Api.Features.Queries.HotelRooms.Requests
{
    public class GetHotelRoomByIdRequest :IRequest<HotelRoomDto>
    {
        public int Id { get; set; }
    }
}