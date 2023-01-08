using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.RoomType;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.RoomTypes.Queries.Requests
{
    public class GetRoomTypeRequestHandler : IQueryHandler<GetRoomTypeRequest, RoomTypeDto>
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
}