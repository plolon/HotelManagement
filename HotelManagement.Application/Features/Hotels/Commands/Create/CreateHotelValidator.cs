using FluentValidation;
using HotelManagement.Application.Features.Commands.Hotels.Requests;
using HotelManagement.Application.Validators;

namespace HotelManagement.Application.Features.Hotels.Commands.Create
{
    public class CreateHotelValidator : AbstractValidator<CreateHotelRequest>
    {
        public CreateHotelValidator()
        {
            RuleFor(req => req.SaveHotelDto.Name)
                .NotEmpty()
                .WithMessage("Hotel Name has not been specified!")
                .MaximumLength(50)
                .WithMessage("Hotel name cannot be longer than 50 characters!");

            RuleFor(req => req.SaveHotelDto.Address)
                .SetValidator(new HotelAddressDtoValidator());
        }
    }
}