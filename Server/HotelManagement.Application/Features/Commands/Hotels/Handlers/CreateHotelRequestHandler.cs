using AutoMapper;
using HotelManagement.Application.DTOs.Hotel;
using HotelManagement.Application.Extensions;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Validators;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Handlers
{
    public class CreateHotelRequestHandler : IRequestHandler<CreateHotelRequest, HotelDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateHotelRequestHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<HotelDto> Handle(CreateHotelRequest request, CancellationToken cancellationToken)
        {
            var hotelDtoValidator = new HotelDtoValidator();
            var validationResult =
                await hotelDtoValidator.ValidateAsync(request.SaveHotelDto);

            if (!validationResult.IsValid)
            {
                var message = validationResult.GenerateErrorMessages();
                //TODO: Implement custom Exception class for HttpErrors
                throw new Exception(message);
            }

            var hotel = _mapper.Map<Hotel>(request.SaveHotelDto);
            hotel = await _unitOfWork.Hotels.Add(hotel);
            await _unitOfWork.Complete();
            return _mapper.Map<HotelDto>(hotel);
        }
    }
}