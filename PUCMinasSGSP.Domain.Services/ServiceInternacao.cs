using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceInternacao : ServiceBase<Internacao>, IServiceInternacao
    {
        private readonly IRepositoryInternacao repositoryInternacao;

        public ServiceInternacao(IRepositoryInternacao repositoryInternacao)
            : base(repositoryInternacao)
        {
            this.repositoryInternacao = repositoryInternacao;
        }
    }
}