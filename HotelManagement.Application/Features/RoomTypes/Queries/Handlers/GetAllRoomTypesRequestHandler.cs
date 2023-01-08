using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Application.Features.RoomTypes.Queries.Requests;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.HotelRooms.Queries.Handlers
{
    public class GetAllRoomTypesRequestHandler : IQueryHandler<GetAllRoomTypesRequest, ICollection<RoomTypeDto>>
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