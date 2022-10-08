using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.Queries.RoomTypes.Requests;

public class GetAllRoomTypesRequest :IRequest<ICollection<RoomTypeDto>>
{
    
}