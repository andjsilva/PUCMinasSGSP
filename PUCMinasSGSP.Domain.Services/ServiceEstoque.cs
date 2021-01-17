using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceEstoque : ServiceBase<Estoque>, IServiceEstoque
    {
        private readonly IRepositoryEstoque repositoryEstoque;

        public ServiceEstoque(IRepositoryEstoque repositoryEstoque)
            : base(repositoryEstoque)
        {
            this.repositoryEstoque = repositoryEstoque;
        }
    }
}