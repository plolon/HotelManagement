using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Handlers
{
    public class GetAllHotelsRequestHandler : IRequestHandler<GetAllHotelsRequest, ICollection<HotelDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllHotelsRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<HotelDto>> Handle(GetAllHotelsRequest request, CancellationToken cancellationToken)
        {
            var hotels = await _unitOfWork.Hotels.GetAll();
            return _mapper.Map<ICollection<HotelDto>>(hotels);
        }
    }
}
