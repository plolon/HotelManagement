using FluentValidation;
using HotelManagement.Application.DTOs.Hotel;

namespace HotelManagement.Application.Validators
{
    public class HotelDtoValidator : AbstractValidator<SaveHotelDto>
    {
        public HotelDtoValidator()
        {
            RuleFor(hotel => hotel.Name)
                .NotEmpty()
                .WithMessage("Hotel Name has not been specified!")
                .MaximumLength(50)
                .WithMessage("Hotel name cannot be longer than 50 characters!");

            RuleFor(hotel => hotel.Address)
                .SetValidator(new HotelAddressDtoValidator());
        }
    }
}