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
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasMany(x => x.Products).WithOne(x => x.Category);



            builder.HasData(
                    new Category { Id = 1, Name = "motor" },
                    new Category { Id = 2, Name = "motor" },
                    new Category { Id = 3, Name = "motor" },
                    new Category { Id = 4, Name = "motor" },
                    new Category { Id = 5, Name = "motor" },
                    new Category { Id = 6, Name = "motor" },
                    new Category { Id = 7, Name = "motor" });



        }
    }
    }

