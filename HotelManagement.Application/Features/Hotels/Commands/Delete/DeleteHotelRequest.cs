using HotelManagement.Application.Abstraction;
using MediatR;

namespace HotelManagement.Application.Features.Commands.Hotels.Requests
{
    public class DeleteHotelRequest : ICommand<bool>
    {
        public int Id { get; set; }
    }
}