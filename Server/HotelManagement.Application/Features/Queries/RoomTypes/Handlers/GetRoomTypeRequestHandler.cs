using AutoMapper;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Application.Features.Queries.RoomTypes.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Queries.RoomTypes.Handlers;

public class GetRoomTypeRequestHandler : IRequestHandler<GetRoomTypeRequest, RoomTypeDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetRoomTypeRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task<RoomTypeDto> Handle(GetRoomTypeRequest request, CancellationToken cancellationToken)
    {
        var roomtype = await _unitOfWork.RoomTypes.Get(request.Id);
        return _mapper.Map<RoomTypeDto>(roomtype);
    }
}