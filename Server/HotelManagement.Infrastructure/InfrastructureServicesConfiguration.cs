﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HotelManagement.Infrastructure
{
    public static class InfrastructureServicesConfiguration
    {
        public static IServiceCollection RegisterInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HotelManagementDbContext>(options => 
                options.UseSqlite(configuration.GetConnectionString("Default")));
            return services;
        }
    }
}
