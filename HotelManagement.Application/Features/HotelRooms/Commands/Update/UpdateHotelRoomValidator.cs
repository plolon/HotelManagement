using FluentValidation;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Update;

public class
    UpdateHotelRoomValidator : AbstractValidator<UpdateHotelRoomRequest>
{
    public UpdateHotelRoomValidator()
    {
        RuleFor(req => req.Id)
            .NotEmpty()
            .WithMessage("ID CANNOT BE EMPTY");
        RuleFor(req => req.UpdateHotelRoomDto).NotNull()
            .WithMessage("Cannot update with empty data!");
    }
}