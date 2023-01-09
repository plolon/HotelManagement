using HotelManagement.Application.Abstraction.Messaging;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Domain.Repositories;
using MediatR;

namespace HotelManagement.Application.Features.Bookings.Commands.Delete
{
    public class
        DeleteBookingRequestHandler : ICommandHandler<DeleteBookingRequest,
            bool>
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteBookingRequestHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Handle(DeleteBookingRequest request,
            CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Bookings.Delete(request.Id);
            await _unitOfWork.Complete();
            return result;
        }
    }
}