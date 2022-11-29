using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelManagement.Infrastructure.Configuration
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    UserId = "d76c6509-a64a-4c53-a650-1ab645b7dab9",
                    RoleId = "a986fb26-1e37-49f8-b7c6-363d5b1be4b9"
                },
                new IdentityUserRole<string>
                {
                    UserId = "182f77d7-964e-468a-8c13-8c0118287ca3",
                    RoleId = "f94000ea-05fe-43da-a5d3-64b2d646c9dc"
                },
                new IdentityUserRole<string>
                {
                    UserId = "7f5923af-d1b4-41ce-8db8-cef9863ac90b",
                    RoleId = "b693c6bd-3b96-4403-ad5c-f3c773d504d9",
                });
        }
    }
}