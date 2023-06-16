﻿using BackendPostVentas.WareHouse.Domain.Brands;
using BackendPostVentas.WareHouse.Infrastructure.Brands.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BackendPostVentas.WareHouse.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWareHouseInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IBrandRepository, BrandRepository>();

            services.AddWareHousePersistence();

            return services;
        }

        private static IServiceCollection AddWareHousePersistence(this IServiceCollection services)
        {
            return services;
        }
    }
}