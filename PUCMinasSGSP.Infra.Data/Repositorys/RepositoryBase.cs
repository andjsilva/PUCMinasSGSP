using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SGSPContext dbContext;

        public RepositoryBase(SGSPContext dbContext)
        {
            this.dbContext = dbContext;

            //Configuracao global para desligar o controle de estado dos objetos EF
            this.dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        public TEntity Add(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>().Add(obj);
                this.dbContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>().AsNoTracking<TEntity>().ToList();
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

        public TEntity Update(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>().Update(obj);
                this.dbContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}