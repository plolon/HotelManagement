using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Domain.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateBookingMappings()
        {
            CreateMap<BookingDto, Booking>();

            CreateMap<Booking, BookingDto>();
        }
    }
}