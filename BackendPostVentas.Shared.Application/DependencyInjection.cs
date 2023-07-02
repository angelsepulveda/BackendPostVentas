using BackendPostVentas.Shared.Application.Behaviors;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BackendPostVentas.Shared.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSharedApplication(this IServiceCollection services)
        {
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
           
            return services;
        }
    }
}
