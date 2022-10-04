using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Api.Features.Queries.RoomTypes.Requests;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Handlers;

public class GetRoomTypeRequestHandler : IRequestHandler<GetRoomTypeRequest, RoomTypeDto>
{
    public Task<RoomTypeDto> Handle(GetRoomTypeRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}