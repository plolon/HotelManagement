using AutoMapper;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Bookings.Commands.Update
{
    public class
        UpdateBookingRequestHandler : IRequestHandler<UpdateBookingRequest,
            BookingDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateBookingRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BookingDto> Handle(UpdateBookingRequest request,
            CancellationToken cancellationToken)
        {
            if (request.Id == null)
            {
                return null;
            }

            var booking = await _unitOfWork.Bookings.Get(request.Id);
            _mapper.Map(request.UpdateBookingDto, booking);
            await _unitOfWork.Bookings.Update(booking);
            var res = _mapper.Map<BookingDto>(booking);
            return res;
        }
    }
}