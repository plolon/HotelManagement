using HotelManagement.Application.DTOs.RoomType;
using MediatR;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
    public class GetAllRoomTypesRequest : IRequest<ICollection<RoomTypeDto>>
    {

    }
}