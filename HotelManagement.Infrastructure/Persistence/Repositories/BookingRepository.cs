using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Persistence.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}