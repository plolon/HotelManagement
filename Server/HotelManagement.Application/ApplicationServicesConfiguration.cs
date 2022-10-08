using HotelManagement.Application.Profiles;
using MediatR;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Application
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
