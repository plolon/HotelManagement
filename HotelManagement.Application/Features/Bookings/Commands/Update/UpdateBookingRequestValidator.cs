using FluentValidation;

namespace HotelManagement.Application.Features.Bookings.Commands.Update;

public class UpdateBookingRequestValidator : AbstractValidator<UpdateBookingRequest>
{
    public UpdateBookingRequestValidator()
    {
        RuleFor(req => req.Id).NotNull();
        RuleFor(req => req.UpdateBookingDto).NotEmpty();
        RuleFor(req => req.UpdateBookingDto.HotelRoomId)
            .NotEmpty()
            .WithMessage("ROOM ID NOT SPECIFIED");

        RuleFor(req => req.UpdateBookingDto.EndDate)
            .NotEmpty()
            .WithMessage("END DATE CANNOT BE EMPTY");

        RuleFor(req => req.UpdateBookingDto.StartDate)
            .NotEmpty()
            .WithMessage("START DATE CANNOT BE EMPTY");

        RuleFor(req => req.UpdateBookingDto.StatusId)
            .NotEmpty()
            .WithMessage("STATUS ID CANNOT BE EMPTY");
    }
}