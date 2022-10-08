using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.Queries.RoomTypes.Requests;

public class GetRoomTypeRequest : IRequest<RoomTypeDto>
{
    public int Id { get; set; }
}