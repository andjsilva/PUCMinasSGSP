using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SGSPContext dbContext;

        public RepositoryProduto(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}