using HotelManagement.Api.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Requests;

public class GetRoomTypeRequest : IRequest<RoomTypeDto>
{
    public int Id { get; set; }
}