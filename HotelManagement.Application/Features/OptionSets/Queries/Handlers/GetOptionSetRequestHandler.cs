using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.OptionSets;
using HotelManagement.Application.Features.OptionSets.Queries.Requests;
using HotelManagement.Domain.Models.OptionSets;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.OptionSets.Queries.Handlers
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
            var repo = _unitOfWork.GetGenericRepository<RoomType>();
            var roomtypes = await repo.GetAll();
            return _mapper.Map<ICollection<RoomTypeDto>>(roomtypes);
        }
    }   
    public class GetAllStatusesHandler : IQueryHandler<GetAllStatusesRequest, ICollection<StatusDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllStatusesHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ICollection<StatusDto>> Handle(GetAllStatusesRequest request, CancellationToken cancellationToken)
        {
            var repo = _unitOfWork.GetGenericRepository<Status>();
            var statuses = await repo.GetAll();
            return _mapper.Map<ICollection<StatusDto>>(statuses);
        }
    }   
}