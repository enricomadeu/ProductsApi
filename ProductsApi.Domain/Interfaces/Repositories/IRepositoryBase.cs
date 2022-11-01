using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity>
        where TEntity: BaseEntity
    {
        int Include(TEntity entity);
        void Exclude(int id);
        void Exclude(TEntity entity);
        void Update(TEntity entity);
        TEntity SelectById(int id);
        IEnumerable<TEntity> SelectAll();
    }
}
