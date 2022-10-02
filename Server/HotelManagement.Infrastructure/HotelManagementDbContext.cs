using HotelManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Infrastructure
{
    public class HotelManagementDbContext :DbContext
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) :base(options) {}

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelManagementDbContext).Assembly);
        }

        // TODO
        // add auto populate createdDate on create
        // add auto populate modifiedDate on update and create
    }
}
