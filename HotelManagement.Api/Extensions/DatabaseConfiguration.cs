using HotelManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Api.Extensions
{
    public static class DatabaseConfiguration
    {
        public static IApplicationBuilder PrepareDatabase(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                try
                {
                    var dbContext = scope.ServiceProvider.GetService<HotelManagementDbContext>();
                    if (dbContext == null)
                        return app;
                    dbContext.Database.Migrate();
                }
                catch (Exception ex)
                {
                    //log exception
                }
            }
            return app;
        }
    }
}
