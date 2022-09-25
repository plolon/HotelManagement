using HotelManagement.Api.Profiles;
using MediatR;
using System.Reflection;

namespace HotelManagement.Api
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
