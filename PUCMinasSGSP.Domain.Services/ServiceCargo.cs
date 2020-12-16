using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceCargo : ServiceBase<Cargo>, IServiceCargo
    {
        private readonly IRepositoryCargo repositoryCargo;

        public ServiceCargo(IRepositoryCargo repositoryCargo)
            :base(repositoryCargo)
        {
            this.repositoryCargo = repositoryCargo;
        }
    }
}
