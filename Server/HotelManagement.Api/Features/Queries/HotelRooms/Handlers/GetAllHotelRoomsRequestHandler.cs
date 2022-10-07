using AutoMapper;
using HotelManagement.Api.DTOs.HotelRoom;
using HotelManagement.Api.Features.Queries.HotelRooms.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.HotelRooms.Handlers
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
            var hotels = await _unitOfWork.HotelRooms.GetAll();
            return _mapper.Map<ICollection<HotelRoomDto>>(hotels);
        }
    }
}