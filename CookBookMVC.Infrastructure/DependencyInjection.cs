using System;
using System.Collections.Generic;
using System.Text;
using CookBookMVC.Domain.InterfaceRepository;
using CookBookMVC.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CookBookMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            return services;
        }
    }
}
