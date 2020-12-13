using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PUCMinasSGSP.Infra.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SGSPContext dbContext;

        public RepositoryBase(SGSPContext dbContext)
        {
            this.dbContext = dbContext;

            //Configuracao global para desligar o controle de estado dos objetos EF
            //this.dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

        }

        public virtual TEntity Add(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Add(obj);
                this.dbContext.SaveChanges();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return this.dbContext.Set<TEntity>()
                                 .AsNoTracking<TEntity>()
                                 .ToList();
        }

        public virtual TEntity GetById(Guid id)
        {
            var idEntity = typeof(TEntity).GetProperty("Id");
            var result = this.dbContext.Set<TEntity>()
                                       .AsNoTracking<TEntity>()
                                       .AsEnumerable()
                                       .Where<TEntity>(x => (Guid)idEntity.GetValue(x) == id)

                        .FirstOrDefault();
            return result;

        }


        public virtual void Remove(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Remove(obj);
                this.dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void Update(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Update(obj);
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}