using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryEstoque: RepositoryBase<Estoque>, IRepositoryEstoque
    {
        private readonly SGSPContext dbContext;

        public RepositoryEstoque(SGSPContext dbContext)
            :base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
