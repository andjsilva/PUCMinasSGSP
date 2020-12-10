using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using PUCMinasSGSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServicePaciente : ServiceBase<Paciente>, IServicePaciente
    {
        private readonly IRepositoryPaciente repositoryPaciente;

        public ServicePaciente(IRepositoryPaciente repositoryPaciente)
            :base(repositoryPaciente)
        {
            this.repositoryPaciente = repositoryPaciente;
        }
    }
}
