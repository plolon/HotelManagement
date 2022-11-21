using HotelManagement.Domain.Models.OptionSets;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Repositories
{
    public class RoomTypeRepository : GenericRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }
    }
}