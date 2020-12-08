using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Interfaces.Repositorys;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SGSPDbContext dbContext;

        public RepositoryBase(SGSPDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>().Add(obj);
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return this.dbContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>().Remove(obj);
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>().Update(obj);
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}