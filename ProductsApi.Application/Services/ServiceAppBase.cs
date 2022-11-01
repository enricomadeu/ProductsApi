using AutoMapper;
using ProductsApi.Application.DTO;
using ProductsApi.Application.Interfaces;
using ProductsApi.Domain.Entities;
using ProductsApi.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Application.Services
{
    public class ServiceAppBase<TEntity, TEntityDTO> : IAppBase<TEntity, TEntityDTO>
        where TEntity : BaseEntity
        where TEntityDTO : BaseDTO
    {
        protected readonly IServiceBase<TEntity> service;
        protected readonly IMapper mapper;

        public ServiceAppBase(IMapper mapper, IServiceBase<TEntity> service) : base()
        {
            this.mapper = mapper;
            this.service = service;
        }

        public void Update(TEntityDTO entity)
        {
            service.Update(mapper.Map<TEntity>(entity));
        }

        public void Exclude(int id)
        {
            service.Exclude(id);
        }

        public void Exclude(TEntityDTO entity)
        {
            service.Exclude(mapper.Map<TEntity>(entity));
        }

        public int Include(TEntityDTO entity)
        {
            return service.Include(mapper.Map<TEntity>(entity));
        }

        public TEntityDTO SelectById(int id)
        {
            return mapper.Map<TEntityDTO>(service.SelectById(id));
        }

        public IEnumerable<TEntityDTO> SelectAll()
        {
            return mapper.Map<IEnumerable<TEntityDTO>>(service.SelectAll());
        }
    }
}
