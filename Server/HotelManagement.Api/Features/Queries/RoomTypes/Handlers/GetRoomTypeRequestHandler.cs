using AutoMapper;
using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Api.Features.Queries.RoomTypes.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Handlers;

public class GetRoomTypeRequestHandler : IRequestHandler<GetRoomTypeRequest, RoomTypeDto>
{
    private readonly IRoomTypeRepository _roomTypeRepository;
    private readonly IMapper _mapper;

    public GetRoomTypeRequestHandler(IRoomTypeRepository roomTypeRepository, IMapper mapper)
    {
        _roomTypeRepository = roomTypeRepository;
        _mapper = mapper;
    }
    public async Task<RoomTypeDto> Handle(GetRoomTypeRequest request, CancellationToken cancellationToken)
    {
        var roomtype = await _roomTypeRepository.Get(request.Id);
        return _mapper.Map<RoomTypeDto>(roomtype);
    }
}