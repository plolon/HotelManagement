using FluentValidation;
using HotelManagement.Application.DTOs.Hotel;

namespace HotelManagement.Application.Validators;

public class HotelAddressDtoValidator: AbstractValidator<HotelAddressDto>
{
    public HotelAddressDtoValidator()
    {
        RuleFor(hotel => hotel.City)
            .NotEmpty()
            .WithMessage("City cannot be empty!")
            .MaximumLength(100)
            .WithMessage("City name cannot be longer than 100 characters!");

        RuleFor(hotel => hotel.Country)
            .NotEmpty()
            .WithMessage("Country cannot be empty!")
            .MaximumLength(100)
            .WithMessage("Country name cannot be longer than 100 characters!");

        RuleFor(hotel => hotel.Street)
            .NotEmpty()
            .WithMessage("Street cannot be empty!")
            .MaximumLength(100)
            .WithMessage("Street cannot be longer than 100 characters!");
    }
}