using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceLeito : ServiceBase<Leito>, IServiceLeito
    {
        private readonly IRepositoryLeito repositoryLeito;

        public ServiceLeito(IRepositoryLeito repositoryLeito)
            : base(repositoryLeito)
        {
            this.repositoryLeito = repositoryLeito;
        }
    }
}