using Auth.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(new ApplicationUser
                {
                    Id = "d76c6509-a64a-4c53-a650-1ab645b7dab9",
                    Email = "admin@localhost.pl",
                    NormalizedEmail = "ADMIN@LOCALHOST.PL",
                    FirstName = "System",
                    LastName = "Admin",
                    UserName = "admin@localhost.pl",
                    NormalizedUserName = "ADMIN@LOCALHOST.PL",
                    PasswordHash = hasher.HashPassword(null, "insideyouaretwowolves"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "182f77d7-964e-468a-8c13-8c0118287ca3",
                    Email = "employee@localhost.pl",
                    NormalizedEmail = "EMPLOYEE@LOCALHOST.PL",
                    FirstName = "System",
                    LastName = "Employee",
                    UserName = "employee@localhost.pl",
                    NormalizedUserName = "EMPLOYEE@LOCALHOST.PL",
                    PasswordHash = hasher.HashPassword(null, "oneisgay"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "7f5923af-d1b4-41ce-8db8-cef9863ac90b",
                    Email = "user@localhost.pl",
                    NormalizedEmail = "USER@LOCALHOST.PL",
                    FirstName = "System",
                    LastName = "User",
                    UserName = "user@localhost.pl",
                    NormalizedUserName = "USER@LOCALHOST.PL",
                    PasswordHash = hasher.HashPassword(null, "otheroneisgaytoo"),
                    EmailConfirmed = true
                }
            );
        }
    }
}