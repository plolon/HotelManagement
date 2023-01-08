using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Features.Hotels.Queries.Requests;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Application.Features.Hotels.Queries.Handlers
{
    public class
        GetHotelByIdRequestHandler : IQueryHandler<GetHotelByIdRequest,
            HotelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetHotelByIdRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<HotelDto> Handle(GetHotelByIdRequest request,
            CancellationToken cancellationToken)
        {
            var hotel = await _unitOfWork.Hotels.Get(request.Id);
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}