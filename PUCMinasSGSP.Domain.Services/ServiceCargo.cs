using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceCargo : ServiceBase<Cargo>, IServiceCargo
    {
        private readonly IRepositoryCargo repositoryCargo;

        public ServiceCargo(IRepositoryCargo repositoryCargo)
            : base(repositoryCargo)
        {
            this.repositoryCargo = repositoryCargo;
        }
    }
}