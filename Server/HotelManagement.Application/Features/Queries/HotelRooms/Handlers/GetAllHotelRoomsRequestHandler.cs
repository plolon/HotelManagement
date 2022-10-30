using AutoMapper;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;
using HotelManagement.Infrastructure.Persistence;
using MediatR;

namespace HotelManagement.Application.Features.Queries.HotelRooms.Handlers
{
    public class GetAllHotelRoomsRequestHandler :IRequestHandler<GetAllHotelRoomsRequest, ICollection<HotelRoomDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllHotelRoomsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ICollection<HotelRoomDto>> Handle(GetAllHotelRoomsRequest request, CancellationToken cancellationToken)
        {
            var hotels = await _unitOfWork.HotelRooms.GetAllHotelRoomsWithDetails();
            return _mapper.Map<ICollection<HotelRoomDto>>(hotels);
        }
    }
}