using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceUnidadeAtendimento : ServiceBase<UnidadeAtendimento>, IServiceUnidadeAtendimento
    {
        private readonly IRepositoryUnidadeAtendimento repositoryUnidadeAtendimento;

        public ServiceUnidadeAtendimento(IRepositoryUnidadeAtendimento repositoryUnidadeAtendimento)
            : base(repositoryUnidadeAtendimento)
        {
            this.repositoryUnidadeAtendimento = repositoryUnidadeAtendimento;
        }
    }
}