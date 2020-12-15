using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public async Task<TEntity> AddAsync(TEntity obj)
        {
           return await this.repository.AddAsync(obj);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await this.repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await this.repository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(TEntity obj)
        {
            await this.repository.RemoveAsync(obj); 
        }

        public async Task UpdateAsync(TEntity obj)
        {
            await this.repository.UpdateAsync(obj);
        }
    }
}
