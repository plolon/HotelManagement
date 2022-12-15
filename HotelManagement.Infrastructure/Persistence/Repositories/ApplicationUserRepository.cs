using HotelManagement.Domain.Models;
using HotelManagement.Domain.Repositories;

namespace HotelManagement.Infrastructure.Persistence.Repositories 
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly HotelManagementDbContext _dbContext;
        public ApplicationUserRepository(HotelManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}