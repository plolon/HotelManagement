using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Hotels.Queries.Requests;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.Hotels.Queries.Handlers
{
    public class GetAllHotelsRequestHandler : IQueryHandler<GetAllHotelsRequest,
        ICollection<HotelDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllHotelsRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<HotelDto>> Handle(
            GetAllHotelsRequest request, CancellationToken cancellationToken)
        {
            var hotels = await _unitOfWork.Hotels.GetAll();
            return _mapper.Map<ICollection<HotelDto>>(hotels);
        }
    }
}