﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace PersonalBrand.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
