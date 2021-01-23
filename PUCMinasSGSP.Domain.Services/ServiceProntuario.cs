using System;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceProntuario : ServiceBase<Prontuario>, IServiceProntuario
    {
        private readonly IRepositoryProntuario repositoryProntuario;

        public ServiceProntuario(IRepositoryProntuario repositoryProntuario)
            : base(repositoryProntuario)
        {
            this.repositoryProntuario = repositoryProntuario;
        }
    }
}
