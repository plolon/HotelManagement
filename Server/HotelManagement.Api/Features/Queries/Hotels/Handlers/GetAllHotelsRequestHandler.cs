using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Handlers
{
    public class GetAllHotelsRequestHandler : IRequestHandler<GetAllHotelsRequest, ICollection<HotelDto>>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public GetAllHotelsRequestHandler(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<HotelDto>> Handle(GetAllHotelsRequest request, CancellationToken cancellationToken)
        {
            var hotels = await _hotelRepository.GetAll();
            return _mapper.Map<ICollection<HotelDto>>(hotels);
        }
    }
}
