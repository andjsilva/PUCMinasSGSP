using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryUnidadeAtendimento : RepositoryBase<UnidadeAtendimento>, IRepositoryUnidadeAtendimento
    {
        private readonly SGSPContext dbContext;

        public RepositoryUnidadeAtendimento(SGSPContext dbContext)
            :base(dbContext)
        {
            this.dbContext = dbContext;
        }


        public override async Task<UnidadeAtendimento> GetByIdAsync(Guid id)
        {
            var result = await this.dbContext.UnidadeAtendimento
                                             .AsNoTracking()
                                             .Include(x => x.Endereco)
                                             .Include(x => x.Telefones)
                                             .AsQueryable()
                                             .Where(x => x.Id == id)
                                             .FirstOrDefaultAsync();
            return result;
        }

        public override async Task<IEnumerable<UnidadeAtendimento>> GetAllAsync()
        {
            var result = await this.dbContext.UnidadeAtendimento
                                             .AsNoTracking()
                                             .Include(x => x.Endereco)
                                             .Include(x => x.Telefones)
                                             .ToListAsync();

            return result;
        }
    }
}
