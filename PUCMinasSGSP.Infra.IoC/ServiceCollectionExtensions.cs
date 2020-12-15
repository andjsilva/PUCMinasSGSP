using Microsoft.Extensions.DependencyInjection;
using PUCMinasSGSP.Application;
using PUCMinasSGSP.Application.Interfaces;
using PUCMinasSGSP.Application.Interfaces.Mappers;
using PUCMinasSGSP.Application.Mappers;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Services;
using PUCMinasSGSP.Infra.Data.Context;
using PUCMinasSGSP.Infra.Data.Repositorys;
using System;

namespace PUCMinasSGSP.Infra.IoC
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterDependencyInjectionSGSP(this IServiceCollection services)
        {
            services = services ?? throw new ArgumentNullException(nameof(services));
            RegisterDependencyInjection(services);
            return services;
        }

        private static void RegisterDependencyInjection(IServiceCollection services)
        {
            
            //IoC Application
            services.AddTransient<IApplicationServicePaciente,ApplicationServicePaciente>();
            services.AddTransient<IApplicationServiceEndereco, ApplicationServiceEndereco>();
            services.AddTransient<IApplicationServiceUnidadeAtendimento, ApplicationServiceUnidadeAtendimento>();

            //IoC Domain Services
            services.AddTransient<IServicePaciente, ServicePaciente>();
            services.AddTransient<IServiceEndereco, ServiceEndereco>();
            services.AddTransient<IServiceUnidadeAtendimento, ServiceUnidadeAtendimento>();

            //IoC Repositorys
            services.AddTransient<IRepositoryPaciente, RepositoryPaciente>();
            services.AddTransient<IRepositoryEndereco, RepositoryEndereco>();
            services.AddTransient<IRepositoryUnidadeAtendimento, RepositoryUnidadeAtendimento>();

            //IoC Mappper
            services.AddTransient<IMapperPaciente, MapperPaciente>();
            services.AddTransient<IMapperEndereco, MapperEndereco>();
            services.AddTransient<IMapperUnidadeAtendimento, MapperUnidadeAtendimento>();


        }


    }
}
