using AutoMapper;
using HotelManagement.Application.DTOs.HotelRoom;
using HotelManagement.Application.Features.Queries.HotelRooms.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
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
            var hotel = await _unitOfWork.HotelRooms.GetHotelRoomWithDetailsById(request.Id);
            return _mapper.Map<HotelRoomDto>(hotel);
        }
    }
}