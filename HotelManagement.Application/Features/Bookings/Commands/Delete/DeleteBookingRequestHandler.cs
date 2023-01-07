using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Bookings.Commands.Delete
{
    public class
        DeleteBookingRequestHandler : IRequestHandler<DeleteHotelRequest, bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBookingRequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteHotelRequest request,
            CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Hotels.Delete(request.Id);
            await _unitOfWork.Complete();
            return result;
        }
    }
}