using ProductsApi.Application.DTO;
using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Application.Interfaces
{
    public interface IProductApp : IAppBase<Product, ProductDTO>
    {
    }
}
