using ProductsApi.Application.DTO;
using ProductsApi.Application.Interfaces;
using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsApi.Services.Controllers
{
    public class ProductController : ControllerBase<Product, ProductDTO>
    {
        public ProductController(IProductApp app) : base(app)
        {

        }
    }
}
