using HotelManagement.Domain.Repositories;
using HotelManagement.Infrastructure.Persistence;
using HotelManagement.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Infrastructure
{
    public static class InfrastructureServicesConfiguration
    {
        public static IServiceCollection RegisterInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            var connString =
                configuration.GetConnectionString("hotelmanagement-db");
            services.AddDbContext<HotelManagementDbContext>(options =>
                options.UseMySql(connString,
                    ServerVersion.AutoDetect(connString)));
            services.RegisterRepositories();
            

            return services;
        }


        private static IServiceCollection RegisterRepositories(
            this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericRepository<>),
                typeof(GenericRepository<>));
            services
                .AddScoped<IApplicationUserRepository,
                    ApplicationUserRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IHotelRoomRepository, HotelRoomRepository>();
            services.AddScoped<IRoomTypeRepository, RoomTypeRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}