using HotelManagement.Infrastructure.Persistence.Common;
using HotelManagement.Infrastructure.Persistence.IRepositories;
using HotelManagement.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Infrastructure
{
    public static class InfrastructureServicesConfiguration
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<HotelManagementDbContext>(options =>
                options.UseSqlite(configuration.GetConnectionString("Default")));

            var repositoryAssembly = typeof(GenericRepository<>).Assembly;
            var registrations =
                from type in repositoryAssembly.GetExportedTypes()
                where type.Namespace.StartsWith("HotelManagement.Infrastructure.Persistence.Repositories")
                from service in type.GetInterfaces()
                where !service.Name.Contains("IGeneric")
                select new { service, implementation = type };
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            registrations.ToList().ForEach(x => services.AddScoped(x.service, x.implementation));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}