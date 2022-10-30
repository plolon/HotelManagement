using HotelManagement.Domain.Models.OptionSets;
using HotelManagement.Infrastructure.Persistence.Common;
using HotelManagement.Infrastructure.Persistence.IRepositories;

namespace HotelManagement.Infrastructure.Persistence.Repositories
{
    public class RoomTypeRepository :GenericRepository<RoomType>, IRoomTypeRepository
    {
        public RoomTypeRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
        }
    }   
}