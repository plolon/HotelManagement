using FluentValidation;

namespace HotelManagement.Application.Features.HotelRooms.Commands.Create;

public class CreateHotelRoomValidator : AbstractValidator<CreateHotelRoomRequest>
{
    public CreateHotelRoomValidator()
    {
        RuleFor(req => req.CreateHotelRoomDto.HotelId)
            .NotEmpty()
            .WithMessage("Hotel ID cannot be empty!");

        RuleFor(req => req.CreateHotelRoomDto.RoomTypeId)
            .NotEmpty()
            .WithMessage("RoomTypeId cannot be empty!");

        RuleFor(req => req.CreateHotelRoomDto.Number).NotEmpty()
            .WithMessage("Room has to have a number!");
    }
}