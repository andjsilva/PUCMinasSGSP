using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryEstoque : RepositoryBase<Estoque>, IRepositoryEstoque
    {
        private readonly SGSPContext dbContext;

        public RepositoryEstoque(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}