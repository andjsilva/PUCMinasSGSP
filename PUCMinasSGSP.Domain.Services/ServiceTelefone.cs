using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceTelefone: ServiceBase<Telefone>, IServiceTelefone
    {
        private readonly IRepositoryTelefone repositoryTelefone;

        public ServiceTelefone(IRepositoryTelefone repositoryTelefone)
            :base(repositoryTelefone)
        {
            this.repositoryTelefone = repositoryTelefone;
        }
    }
}
