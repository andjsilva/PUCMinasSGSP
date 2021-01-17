using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryTelefone : RepositoryBase<Telefone>, IRepositoryTelefone
    {
        private readonly SGSPContext dbContext;

        public RepositoryTelefone(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}