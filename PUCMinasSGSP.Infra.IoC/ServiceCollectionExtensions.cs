using Microsoft.Extensions.DependencyInjection;
using PUCMinasSGSP.Infra.Data.Context;
using System;

namespace PUCMinasSGSP.Infra.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDependencyInjectionSGSPAPI(this IServiceCollection services)
        {
            services = services ?? throw new ArgumentNullException(nameof(services));
            RegisterDependencyInjection(services);
            return services;
        }

        private static void RegisterDependencyInjection(IServiceCollection services)
        {
            services.AddTransient<SGSPDbContext>();
        }

           
    }
}
