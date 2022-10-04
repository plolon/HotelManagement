using HotelManagement.Api.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Requests;

public class GetAllRoomTypesRequest :IRequest<ICollection<RoomTypeDto>>
{
    
}