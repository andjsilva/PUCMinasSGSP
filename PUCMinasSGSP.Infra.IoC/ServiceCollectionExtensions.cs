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
            services.AddTransient<IApplicationServiceFuncionario, ApplicationServiceFuncionario>();
            services.AddTransient<IApplicationServiceEndereco, ApplicationServiceEndereco>();
            services.AddTransient<IApplicationServiceTelefone, ApplicationServiceTelefone>();
            services.AddTransient<IApplicationServiceUnidadeAtendimento, ApplicationServiceUnidadeAtendimento>();
            services.AddTransient<IApplicationServiceProduto, ApplicationServiceProduto>();
            services.AddTransient<IApplicationServiceEstoque, ApplicationServiceEstoque>();
            services.AddTransient<IApplicationServiceCargo, ApplicationServiceCargo>();


            //IoC Domain Services
            services.AddTransient<IServicePaciente, ServicePaciente>();
            services.AddTransient<IServiceFuncionario, ServiceFuncionario>();
            services.AddTransient<IServiceEndereco, ServiceEndereco>();
            services.AddTransient<IServiceTelefone, ServiceTelefone>();
            services.AddTransient<IServiceUnidadeAtendimento, ServiceUnidadeAtendimento>();
            services.AddTransient<IServiceProduto, ServiceProduto>();
            services.AddTransient<IServiceEstoque, ServiceEstoque>();
            services.AddTransient<IServiceCargo, ServiceCargo>();

            //IoC Repositorys
            services.AddTransient<IRepositoryPaciente, RepositoryPaciente>();
            services.AddTransient<IRepositoryFuncionario, RepositoryFuncionario>();
            services.AddTransient<IRepositoryEndereco, RepositoryEndereco>();
            services.AddTransient<IRepositoryTelefone, RepositoryTelefone>();
            services.AddTransient<IRepositoryUnidadeAtendimento, RepositoryUnidadeAtendimento>();
            services.AddTransient<IRepositoryProduto, RepositoryProduto>();
            services.AddTransient<IRepositoryEstoque, RepositoryEstoque>();
            services.AddTransient<IRepositoryCargo, RepositoryCargo>();

            //IoC Mappper
            services.AddTransient<IMapperPaciente, MapperPaciente>();
            services.AddTransient<IMapperFuncionario, MapperFuncionario>();
            services.AddTransient<IMapperEndereco, MapperEndereco>();
            services.AddTransient<IMapperTelefone, MapperTelefone>();
            services.AddTransient<IMapperUnidadeAtendimento, MapperUnidadeAtendimento>();
            services.AddTransient<IMapperProduto, MapperProduto>();
            services.AddTransient<IMapperEstoque, MapperEstoque>();
            services.AddTransient<IMapperCargo, MapperCargo>();


        }


    }
}
