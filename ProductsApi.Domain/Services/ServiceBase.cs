using ProductsApi.Domain.Entities;
using ProductsApi.Domain.Interfaces.Repositories;
using ProductsApi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity: BaseEntity
    {
        protected readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Update(TEntity entity)
        {
            repository.Update(entity);
        }

        public void Exclude(int id)
        {
            repository.Exclude(id);
        }

        public void Exclude(TEntity entity)
        {
            repository.Exclude(entity);
        }

        public int Include(TEntity entity)
        {
            return repository.Include(entity);
        }

        public TEntity SelectById(int id)
        {
            return repository.SelectById(id);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return repository.SelectAll();
        }
    }
}
