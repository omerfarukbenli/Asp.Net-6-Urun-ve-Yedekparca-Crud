using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(e => e.Category).WithMany(c => c.Products);


            builder.HasData(
                    new Product { Id = 1, Name = "ürün 1", CategoryId = 1 },
                    new Product { Id = 2, Name = "ürün 1", CategoryId = 1 },
                    new Product { Id = 3, Name = "ürün 1", CategoryId = 2 },
                    new Product { Id = 4, Name = "ürün 1", CategoryId = 2 },
                    new Product { Id = 5, Name = "ürün 1", CategoryId = 3 },
                    new Product { Id = 6, Name = "ürün 1", CategoryId = 3 },
                    new Product { Id = 7, Name = "ürün 1", CategoryId = 4 },
                    new Product { Id = 8, Name = "ürün 1", CategoryId = 4 },
                    new Product { Id = 9, Name = "ürün 1", CategoryId = 5 },
                    new Product { Id = 10, Name = "ürün 1", CategoryId = 5 });

        }
    }
}
