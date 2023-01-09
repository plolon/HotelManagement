using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Update;

public class
    UpdateHotelRoomRequestHandler : ICommandHandler<UpdateHotelRoomRequest,
        HotelRoomDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateHotelRoomRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<HotelRoomDto> Handle(UpdateHotelRoomRequest request,
        CancellationToken cancellationToken)
    {
        var hotelRoom = await _unitOfWork.HotelRooms.Get(request.Id);
        _mapper.Map(request.UpdateHotelRoomDto, hotelRoom);

        await _unitOfWork.HotelRooms.Update(hotelRoom);
        await _unitOfWork.Complete();

        var updatedHotelRoom =
            await _unitOfWork.HotelRooms.GetHotelRoomWithDetailsById(hotelRoom
                .Id);

        var res = _mapper.Map<HotelRoomDto>(updatedHotelRoom);
        return res;
    }
}