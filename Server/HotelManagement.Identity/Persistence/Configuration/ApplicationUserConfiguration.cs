using HotelManagement.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
                {
                    Id = 1,
                    Username = "Bob",
                    Password = "kekw",
                    Email = "bob@bob.com",
                    Role = "SuperAdministrator"
                }
            );
            builder.HasData(new User
            {
                Id = 2,
                Username = "Alice",
                Password = "notSoKekw",
                Email = "alice@alice.com",
                Role = "Administrator"
            });
            builder.HasData(new User
            {
                Id = 3,
                Username = "ParisPlatyna",
                Password = "ImPlatBaby",
                Email = "plat@plat.com",
                Role = "Platinum"
            });
        }
    }
}