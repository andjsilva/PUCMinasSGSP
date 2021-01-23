using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceCampanha : ServiceBase<Campanha>, IServiceCampanha
    {
        private readonly IRepositoryCampanha repositoryCampanha;

        public ServiceCampanha(IRepositoryCampanha repositoryCampanha)
            : base(repositoryCampanha)
        {
            this.repositoryCampanha = repositoryCampanha;
        }
    }
}