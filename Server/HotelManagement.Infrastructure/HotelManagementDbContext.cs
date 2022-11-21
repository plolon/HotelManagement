using HotelManagement.Domain.Models;
using HotelManagement.Domain.Models.Common;
using HotelManagement.Domain.Models.OptionSets;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HotelManagement.Infrastructure
{
    public class HotelManagementDbContext : DbContext
    {
        public HotelManagementDbContext(DbContextOptions<HotelManagementDbContext> options) : base(options) { }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelRoom> HotelRooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<HotelRoomBooking> HotelRoomBookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HotelManagementDbContext).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var entries = ChangeTracker.Entries<BaseDomainEntity>();
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.DateCreated = DateTime.Now;
                }
                entry.Entity.DateModified = DateTime.Now;
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
