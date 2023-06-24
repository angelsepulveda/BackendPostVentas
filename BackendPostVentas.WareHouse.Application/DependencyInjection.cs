namespace BackendPostVentas.WareHouse.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWareHouseApplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<WareHouseApplicationAssemblyReference>();
            });

            services.AddValidatorsFromAssemblyContaining<WareHouseApplicationAssemblyReference>();

            return services;
        }
    }
}
