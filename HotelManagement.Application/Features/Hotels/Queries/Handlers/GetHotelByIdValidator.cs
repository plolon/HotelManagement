using FluentValidation;
using HotelManagement.Application.Features.Queries.Bookings.Requests;

namespace HotelManagement.Application.Features.Hotels.Queries.Handlers
{
    public class
        GetHotelByIdValidator : AbstractValidator<GetBookingByIdRequest>
    {
        public GetHotelByIdValidator()
        {
            RuleFor(req => req.Id).NotEmpty()
                .WithMessage("ROOM ID CANNOT BE EMPTY").GreaterThan(0)
                .WithMessage("ROOM ID CANNOT BE NEGATIVE");
        }
    }
}