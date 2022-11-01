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
    public class ProductService : ServiceBase<Product>, IProductService
    {
        public ProductService(IProductRepository repository) : base(repository)
        {

        }
    }
}
