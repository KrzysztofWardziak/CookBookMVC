using System;
using System.Collections.Generic;
using System.Text;
using CookBookMVC.Application.InterfaceService;
using CookBookMVC.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace CookBookMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IIngredientService, IngredientService>();
            return services;
        }
    }
}
