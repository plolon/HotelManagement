using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
public class GetRoomTypeRequest : IRequest<RoomTypeDto>
{
    public int Id { get; set; }
}
}
