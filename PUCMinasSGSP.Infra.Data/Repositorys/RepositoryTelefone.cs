using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryTelefone: RepositoryBase<Telefone>, IRepositoryTelefone
    {
        private readonly SGSPContext dbContext;

        public RepositoryTelefone(SGSPContext dbContext)
            :base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
