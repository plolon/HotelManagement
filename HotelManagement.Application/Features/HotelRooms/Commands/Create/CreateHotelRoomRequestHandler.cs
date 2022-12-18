using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Create
{
    public class CreateHotelRoomRequestHandler : ICommandHandler<CreateHotelRoomRequest, HotelRoomDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateHotelRoomRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
            public async Task<HotelRoomDto> Handle(CreateHotelRoomRequest request,
                CancellationToken cancellationToken)
            {
                // TODO: Check if this does not blow up
                var hotelRoom =
                    _mapper.Map<HotelRoom>(request.CreateHotelRoomDto);
                hotelRoom = await _unitOfWork.HotelRooms.Add(hotelRoom);
                await _unitOfWork.Complete();
                return _mapper.Map<HotelRoomDto>(hotelRoom);
            }
        }
}
