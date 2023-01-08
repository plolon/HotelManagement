using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Booking;
using MediatR;
using HotelManagement.Domain.Repositories;
using HotelManagement.Application.Features.Queries.Bookings.Requests;

namespace HotelManagement.Application.Features.Queries.Hotels.Requests
{
    public class
        GetBookingByIdRequestHandler : IQueryHandler<GetBookingByIdRequest,
            BookingDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBookingByIdRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BookingDto> Handle(GetBookingByIdRequest request,
            CancellationToken cancellationToken)
        {
            var booking = await _unitOfWork.Bookings.Get(request.Id);
            return booking != null ? _mapper.Map<BookingDto>(booking) : null;
        }
    }
}