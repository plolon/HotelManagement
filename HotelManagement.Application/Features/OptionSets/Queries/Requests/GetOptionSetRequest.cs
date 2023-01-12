using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.OptionSets;

namespace HotelManagement.Application.Features.OptionSets.Queries.Requests
{
    public class GetAllRoomTypesRequest : IQuery<ICollection<RoomTypeDto>>
    {
    }
    public class GetAllStatusesRequest : IQuery<ICollection<StatusDto>>
    {
    }
}