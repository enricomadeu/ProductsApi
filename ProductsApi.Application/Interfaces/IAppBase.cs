using ProductsApi.Application.DTO;
using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Application.Interfaces
{
    public interface IAppBase<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        int Include(TEntityDTO entity);
        void Exclude(int id);
        void Exclude(TEntityDTO entity);
        void Update(TEntityDTO entity);
        TEntityDTO SelectById(int id);
        IEnumerable<TEntityDTO> SelectAll();
    }
}
