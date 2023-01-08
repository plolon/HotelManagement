using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
public class GetRoomTypeRequest : IQuery<RoomTypeDto>
{
    public int Id { get; set; }
}
}
