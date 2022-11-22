using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}