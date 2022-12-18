using AutoMapper;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
    public class GetAllRoomTypesRequestHandler :IRequestHandler<GetAllRoomTypesRequest, ICollection<RoomTypeDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllRoomTypesRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ICollection<RoomTypeDto>> Handle(GetAllRoomTypesRequest request, CancellationToken cancellationToken)
        {
            var roomtypes = await _unitOfWork.RoomTypes.GetAll();
            return _mapper.Map<ICollection<RoomTypeDto>>(roomtypes);
        }
    }   
}