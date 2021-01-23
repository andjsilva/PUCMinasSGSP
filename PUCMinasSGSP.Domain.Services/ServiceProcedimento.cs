using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceProcedimento : ServiceBase<Procedimento>, IServiceProcedimento
    {
        private readonly IRepositoryProcedimento repositoryProcedimento;

        public ServiceProcedimento(IRepositoryProcedimento repositoryProcedimento)
            : base(repositoryProcedimento)
        {
            this.repositoryProcedimento = repositoryProcedimento;
        }
    }
}