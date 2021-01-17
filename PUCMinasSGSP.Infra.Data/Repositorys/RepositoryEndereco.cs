using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
    {
        private readonly SGSPContext dbContext;

        public RepositoryEndereco(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}