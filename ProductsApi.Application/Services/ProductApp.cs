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
    public class ProductApp : ServiceAppBase<Product, ProductDTO>, IProductApp
    {
        public ProductApp(IMapper mapper, IProductService service) : base(mapper, service)
        {

        }
    }
}
