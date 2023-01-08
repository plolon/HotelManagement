using AutoMapper;
using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Domain.Repositories;
using HotelManagement.Application.Features.Queries.Bookings.Requests;

namespace HotelManagement.Application.Features.Queries.Bookings.Handlers
{
    public class
        GetAllBookingsRequestHandler : IQueryHandler<GetAllBookingsRequest,
            ICollection<BookingDto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllBookingsRequestHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ICollection<BookingDto>> Handle(
            GetAllBookingsRequest request,
            CancellationToken cancellationToken)
        {
            var bookings = await _unitOfWork.Bookings.GetAll();

            return !bookings.Any()
                ? null
                : _mapper.Map<ICollection<BookingDto>>(bookings);
        }
    }
}