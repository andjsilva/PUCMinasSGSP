using System;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceDetalhesProntuario : ServiceBase<DetalhesProntuario>, IServiceDetalhesProntuario
    {
        private readonly IRepositoryDetalhesProntuario repositoryDetalhesProntuario;

        public ServiceDetalhesProntuario(IRepositoryDetalhesProntuario repositoryDetalhesProntuario)
            : base(repositoryDetalhesProntuario)
        {
            this.repositoryDetalhesProntuario = repositoryDetalhesProntuario;
        }
    }
}
