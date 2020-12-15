﻿using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Entities;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryEndereco : RepositoryBase<Endereco>, IRepositoryEndereco
    {
        private readonly SGSPContext dbContext;

        public RepositoryEndereco(SGSPContext dbContext)
            :base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}