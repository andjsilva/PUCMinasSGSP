using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceDiagnostico : ServiceBase<Diagnostico>, IServiceDiagnostico
    {
        private readonly IRepositoryDiagnostico repositoryDiagnostico;

        public ServiceDiagnostico(IRepositoryDiagnostico repositoryDiagnostico)
            : base(repositoryDiagnostico)
        {
            this.repositoryDiagnostico = repositoryDiagnostico;
        }
    }
}