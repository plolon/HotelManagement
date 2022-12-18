using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
public class GetRoomTypeRequest : IRequest<RoomTypeDto>
{
    public int Id { get; set; }
}
}
