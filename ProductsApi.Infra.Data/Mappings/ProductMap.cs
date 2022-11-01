using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductsApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsApi.Infra.Data.Mappings
{
    public class ProductMap : MapBase<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.ToTable("Products");
            builder.Property(c => c.Description).IsRequired().HasColumnName("Description");
            builder.Property(c => c.Situation).HasColumnName("Situation");
            builder.Property(c => c.FabricationDate).HasColumnName("FabricationDate");
            builder.Property(c => c.ExpirationDate).HasColumnName("ExpirationDate");
            builder.Property(c => c.SupplierCode).HasColumnName("SupplierCode");
            builder.Property(c => c.SupplierDescription).HasColumnName("SupplierDescription");
            builder.Property(c => c.SupplierCNPJ).HasColumnName("SupplierCNPJ");
        }
    }
}
