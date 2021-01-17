using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryCargo : RepositoryBase<Cargo>, IRepositoryCargo
    {
        private readonly SGSPContext dbContext;

        public RepositoryCargo(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}