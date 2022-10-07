using AutoMapper;
using HotelManagement.Api.DTOs.HotelRoom;
using HotelManagement.Api.Features.Queries.HotelRooms.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.HotelRooms.Handlers
{
    public class GetHotelRoomByIdRequestHandler :IRequestHandler<GetHotelRoomByIdRequest, HotelRoomDto>
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
            var hotel = await _unitOfWork.HotelRooms.Get(request.Id);
            return _mapper.Map<HotelRoomDto>(hotel);
        }
    }
}