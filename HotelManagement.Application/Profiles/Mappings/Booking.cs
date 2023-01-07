using HotelManagement.Application.DTOs.Booking;
using HotelManagement.Domain.Models;

namespace HotelManagement.Application.Profiles
{
    public partial class MappingProfile
    {
        public void CreateBookingMappings()
        {
            CreateMap<SaveBookingDto, Booking>()
                .ForMember(b => b.StartDate,
                    opt => opt.MapFrom(cbd =>
                        cbd.StartDate.ToString("yyyy-MM-dd HH:mm:ss")))
                .ForMember(b => b.EndDate,
                    opt => opt.MapFrom(cbd =>
                        cbd.EndDate.ToString("yyyy-MM-dd HH:mm:ss")));
            CreateMap<BookingDto, Booking>();
            CreateMap<Booking, BookingDto>();
        }
    }
}