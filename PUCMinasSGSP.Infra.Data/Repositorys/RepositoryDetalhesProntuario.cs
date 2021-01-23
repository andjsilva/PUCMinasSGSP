using System;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryDetalhesProntuario : RepositoryBase<DetalhesProntuario>, IRepositoryDetalhesProntuario
    {
        private readonly SGSPContext dbContext;

        public RepositoryDetalhesProntuario(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
