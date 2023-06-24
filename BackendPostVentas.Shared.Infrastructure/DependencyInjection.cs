namespace BackendPostVentas.Shared.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddPersistence(configuration);
           
            return services;
        }

        private static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Database")));
            
            services.AddScoped<IApplicationDbContext>(p => p.GetRequiredService<ApplicationDbContext>());
            
            services.AddScoped<IUnitOfWork>(p => p.GetRequiredService<ApplicationDbContext>());

            return services;
        }
    }
}
