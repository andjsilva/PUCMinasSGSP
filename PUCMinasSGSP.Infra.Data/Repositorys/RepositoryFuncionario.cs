﻿using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryFuncionario : RepositoryBase<Funcionario>, IRepositoryFuncionario
    {
        private readonly SGSPContext dbContext;

        public RepositoryFuncionario(SGSPContext dbContext)
            : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public override async Task<Funcionario> GetByIdAsync(Guid id)
        {
            var result = await this.dbContext.Funcionario
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

        public override async Task<IEnumerable<Funcionario>> GetAllAsync()
        {
            var result = await this.dbContext.Funcionario
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