﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);

        TEntity Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(Guid id);

    }
}
