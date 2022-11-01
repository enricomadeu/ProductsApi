using Microsoft.EntityFrameworkCore;
using ProductsApi.Domain.Entities;
using ProductsApi.Domain.Interfaces.Repositories;
using ProductsApi.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly Context context;

        public RepositoryBase(Context context) : base()
        {
            this.context = context;
        }

        public void Update(TEntity entity)
        {
            context.InitTransaction();
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SendChanges();
        }

        public void Exclude(int id)
        {
            var entity = SelectById(id);
            if(entity != null)
            {
                context.InitTransaction();
                context.Set<TEntity>().Remove(entity);
                context.SendChanges();
            }
        }

        public void Exclude(TEntity entity)
        {
            context.InitTransaction();
            context.Set<TEntity>().Remove(entity);
            context.SendChanges();
        }

        public int Include(TEntity entity)
        {
            context.InitTransaction();
            var id = context.Set<TEntity>().Add(entity).Entity.Id;
            context.SendChanges();
            return id;
        }

        public TEntity SelectById(int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return context.Set<TEntity>().ToList();
        }
    }
}
