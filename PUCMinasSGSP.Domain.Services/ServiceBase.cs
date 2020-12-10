using PUCMinasSGSP.Domain.Core.Interfaces.Repositorys;
using PUCMinasSGSP.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PUCMinasSGSP.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {

        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }
        public void Add(TEntity obj)
        {
            this.repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return this.repository.GetAll();
        }

        public TEntity GetById(Guid id)
        {
            return this.repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            this.repository.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            this.repository.Update(obj);
        }
    }
}
