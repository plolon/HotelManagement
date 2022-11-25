using Auth.Repository;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Identity.Persistence
{
    public class HotelManagementIdentityDbContext : DbContext
    {
        public HotelManagementIdentityDbContext(DbContextOptions<HotelManagementIdentityDbContext> options) : base(options)
        {
            
        }

        private DbSet<ApplicationUser> Users { get; set; }
    }
}