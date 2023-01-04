using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Application.Features.Bookings.Commands.Requests;
using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Bookings.Commands.Create
{
    public class CreateBookingRequestHandler : ICommandHandler<
        CreateBookingRequest, BookingDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateBookingRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BookingDto> Handle(CreateBookingRequest request,
            CancellationToken cancellationToken)
        {
            var booking = _mapper.Map<Booking>(request.CreateBookingDto);
            booking = await _unitOfWork.Bookings.Add(booking);

            await _unitOfWork.Complete();
            return _mapper.Map<BookingDto>(booking);
        }
    }
}