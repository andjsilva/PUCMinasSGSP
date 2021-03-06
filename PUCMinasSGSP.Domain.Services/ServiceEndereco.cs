﻿using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceEndereco : ServiceBase<Endereco>, IServiceEndereco
    {
        private readonly IRepositoryEndereco repositoryEndereco;

        public ServiceEndereco(IRepositoryEndereco repositoryEndereco)
            : base(repositoryEndereco)
        {
            this.repositoryEndereco = repositoryEndereco;
        }
    }
}