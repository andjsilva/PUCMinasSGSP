using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceTelefone : ServiceBase<Telefone>, IServiceTelefone
    {
        private readonly IRepositoryTelefone repositoryTelefone;

        public ServiceTelefone(IRepositoryTelefone repositoryTelefone)
            : base(repositoryTelefone)
        {
            this.repositoryTelefone = repositoryTelefone;
        }
    }
}