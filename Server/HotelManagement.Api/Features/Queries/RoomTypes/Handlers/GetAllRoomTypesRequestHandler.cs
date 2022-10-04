using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Api.Features.Queries.RoomTypes.Requests;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Handlers;

public class GetAllRoomTypesRequestHandler :IRequestHandler<GetAllRoomTypesRequest, ICollection<RoomTypeDto>>
{
    public Task<ICollection<RoomTypeDto>> Handle(GetAllRoomTypesRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}