using Microsoft.Extensions.DependencyInjection;
using ProductsApi.Application.Interfaces;
using ProductsApi.Application.Services;
using ProductsApi.Domain.Interfaces.Repositories;
using ProductsApi.Domain.Interfaces.Services;
using ProductsApi.Domain.Services;
using ProductsApi.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Infra.IoC
{
    public class DependencyInjector
    {
        public static void Register(IServiceCollection svcCollection)
        {
            // Application
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServiceAppBase<,>));
            svcCollection.AddScoped<IProductApp, ProductApp>();

            //Domain
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IProductService, ProductService>();

            //Repository
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
