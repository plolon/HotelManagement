using AutoMapper;
using HotelManagement.Api.DTOs.RoomType;
using HotelManagement.Api.Features.Queries.RoomTypes.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.RoomTypes.Handlers;

public class GetAllRoomTypesRequestHandler :IRequestHandler<GetAllRoomTypesRequest, ICollection<RoomTypeDto>>
{
    private readonly IRoomTypeRepository _roomTypeRepository;
    private readonly IMapper _mapper;

    public GetAllRoomTypesRequestHandler(IRoomTypeRepository roomTypeRepository, IMapper mapper)
    {
        _roomTypeRepository = roomTypeRepository;
        _mapper = mapper;
    }
    public async Task<ICollection<RoomTypeDto>> Handle(GetAllRoomTypesRequest request, CancellationToken cancellationToken)
    {
        var roomtypes = await _roomTypeRepository.GetAll();
        return _mapper.Map<ICollection<RoomTypeDto>>(roomtypes);
    }
}