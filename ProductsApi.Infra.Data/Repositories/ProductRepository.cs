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
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(Context context): base(context)
        {

        }
    }
}
