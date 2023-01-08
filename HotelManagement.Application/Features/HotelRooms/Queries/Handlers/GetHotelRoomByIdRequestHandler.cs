using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
    public class GetHotelRoomByIdRequestHandler : IQueryHandler<GetHotelRoomByIdRequest, HotelRoomDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHotelRoomByIdRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<HotelRoomDto> Handle(GetHotelRoomByIdRequest request, CancellationToken cancellationToken)
        {
            var hotel = await _unitOfWork.HotelRooms.GetHotelRoomWithDetailsById(request.Id);
            return _mapper.Map<HotelRoomDto>(hotel);
        }
    }
}