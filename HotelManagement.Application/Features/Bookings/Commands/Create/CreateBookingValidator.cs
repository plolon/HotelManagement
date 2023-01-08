using System.Data;
using FluentValidation;
using HotelManagement.Application.Features.Bookings.Commands.Requests;

namespace HotelManagement.Application.Features.Bookings.Commands.Create
{
    public class
        CreateBookingValidator : AbstractValidator<CreateBookingRequest>
    {
        public CreateBookingValidator()
        {
            RuleFor(req => req.SaveBookingDto.HotelRoomId)
                .NotEmpty()
                .WithMessage("ROOM ID NOT SPECIFIED");

            RuleFor(req => req.SaveBookingDto.EndDate)
                .NotEmpty()
                .WithMessage("END DATE CANNOT BE EMPTY");

            RuleFor(req => req.SaveBookingDto.StartDate)
                .NotEmpty()
                .WithMessage("START DATE CANNOT BE EMPTY");

            RuleFor(req => req.SaveBookingDto.StatusId)
                .NotEmpty()
                .WithMessage("STATUS ID CANNOT BE EMPTY");
        }
    }
}