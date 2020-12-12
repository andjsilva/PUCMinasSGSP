using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryPaciente : RepositoryBase<Paciente>, IRepositoryPaciente
    {
        private readonly SGSPDbContext dbContext;

        public RepositoryPaciente(SGSPDbContext dbContext)
            :base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
