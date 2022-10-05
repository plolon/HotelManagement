using AutoMapper;
using HotelManagement.Api.DTOs.Hotel;
using HotelManagement.Api.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelManagement.Api.Features.Commands.Hotels.Handlers
{
    public class CreateHotelRequestHandler : IRequestHandler<CreateHotelRequest, HotelDto>
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IMapper _mapper;
        public CreateHotelRequestHandler(IHotelRepository hotelRepository, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _mapper = mapper;
        }
        public async Task<HotelDto> Handle(CreateHotelRequest request, CancellationToken cancellationToken)
        {
            var hotelDtoValidator = new HotelDtoValidator();
            var validationResult = await hotelDtoValidator.ValidateAsync(request.SaveHotelDto);

            if (!validationResult.IsValid)
            {
                var message = "";
                validationResult.Errors
                    .Select(x => x.ErrorMessage)
                    .ToList()
                    .ForEach(x => message += x);
                //TODO: Implement custom Exception class for HttpErrors
                throw new Exception(message);
            }
            
            var hotel = _mapper.Map<Hotel>(request.SaveHotelDto);
            hotel = await _hotelRepository.Add(hotel);
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}
