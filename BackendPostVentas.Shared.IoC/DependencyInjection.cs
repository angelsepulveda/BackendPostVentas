using BackendPostVentas.Shared.Infrastructure;
using BackendPostVentas.WareHouse.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackendPostVentas.Shared.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyApplicacion(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddInfrastructure(configuration);
            
            services.AddWareHouseInfrastructure();
            
            return services;
        }
    }
}
    
