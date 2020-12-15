using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryPaciente : RepositoryBase<Paciente>, IRepositoryPaciente
    {
        private readonly SGSPContext dbContext;

        public RepositoryPaciente(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public override async Task<Paciente> GetByIdAsync(Guid id)
        {
            var result = await this.dbContext.Paciente
                                             .AsNoTracking()
                                             .Include(x => x.Documentos)
                                             .Include(x => x.Enderecos)
                                             .Include(x => x.Telefones)
                                             .Include(x => x.Emails)
                                             .AsQueryable()
                                             .Where(x => x.Id == id)
                                             .FirstOrDefaultAsync();
            return result;
        }

        public override async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            var result = await this.dbContext.Paciente
                                             .AsNoTracking()
                                             .Include(x => x.Documentos)
                                             .Include(x => x.Enderecos)
                                             .Include(x => x.Telefones)
                                             .Include(x => x.Emails)
                                             .ToListAsync();

            return result;
        }
    }
}