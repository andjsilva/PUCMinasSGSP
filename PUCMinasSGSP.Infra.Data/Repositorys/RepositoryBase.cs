using Microsoft.EntityFrameworkCore;
using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public virtual async Task<TEntity> AddAsync(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Add(obj);
                await this.dbContext.SaveChangesAsync();
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            var result = await this.dbContext.Set<TEntity>()
                                       .AsNoTracking<TEntity>()
                                       .ToListAsync();
            return result;
        }

        public virtual async Task<TEntity> GetByIdAsync(Guid id)
        {
            var idEntity = typeof(TEntity).GetProperty("Id");
            var result = await this.dbContext.Set<TEntity>()
                                             .AsNoTracking()
                                             .AsQueryable()
                                             .Where(x => (Guid)idEntity.GetValue(x) == id)
                                             .FirstOrDefaultAsync();
            return result;
        }

        public virtual async Task RemoveAsync(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Remove(obj);
                await this.dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual async Task UpdateAsync(TEntity obj)
        {
            try
            {
                this.dbContext.Set<TEntity>()
                              .Update(obj);
                await this.dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}