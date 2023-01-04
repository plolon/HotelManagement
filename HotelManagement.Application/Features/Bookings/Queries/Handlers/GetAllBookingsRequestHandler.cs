using AutoMapper;
using HotelManagement.Application.DTOs.Booking;
using MediatR;
using HotelManagement.Domain.Repositories;
using HotelManagement.Application.Features.Queries.Bookings.Requests;

namespace HotelManagement.Application.Features.Queries.Bookings.Handlers
{
    public class
        GetAllBookingsRequestHandler : IRequestHandler<GetAllBookingsRequest,
            BookingDto>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBookingsRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BookingDto> Handle(GetAllBookingsRequest request,
            CancellationToken cancellationToken)
        {
            var bookings = await _unitOfWork.Bookings.GetAll();

            return !bookings.Any() ? null : _mapper.Map<BookingDto>(bookings);
        }
    }
}