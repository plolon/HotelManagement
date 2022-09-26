using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Queries.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Api.Features.Queries.Hotels.Handlers
{
    public class GetHotelByIdRequestHandler : IRequestHandler<GetHotelByIdRequest, HotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;

        public GetHotelByIdRequestHandler(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<HotelDto> Handle(GetHotelByIdRequest request, CancellationToken cancellationToken)
        {
            var hotel = await _hotelRepository.Get(request.Id);
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}
