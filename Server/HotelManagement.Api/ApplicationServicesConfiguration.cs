using HotelManagement.Api.Profiles;

namespace HotelManagement.Api
{
    public static class ApplicationServicesConfiguration
    {
        public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
