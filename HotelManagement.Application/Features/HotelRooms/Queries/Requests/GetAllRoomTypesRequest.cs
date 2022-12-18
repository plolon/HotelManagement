using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
    public class GetAllRoomTypesRequest : IRequest<ICollection<RoomTypeDto>>
    {

    }
}