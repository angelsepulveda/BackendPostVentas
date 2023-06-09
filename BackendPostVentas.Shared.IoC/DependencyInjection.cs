﻿using BackendPostVentas.Shared.Application;

namespace BackendPostVentas.Shared.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyApplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);
            services.AddWareHouseApplication();
            services.AddWareHouseInfrastructure();
            services.AddSharedApplication();
            
            return services;
        }
    }
}
    
