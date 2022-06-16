using Microsoft.EntityFrameworkCore;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Configurations
{
    public class CategorySparepartConfiguration : IEntityTypeConfiguration<CategorySparepart>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CategorySparepart> builder)
        {
            builder.HasKey(a => new { a.CategoryId, a.SparepartId });
            builder.HasOne(pt => pt.Category).WithMany(p => p.CategorySpareparts).HasForeignKey(pt => pt.CategoryId);
            builder.HasOne(pt => pt.Sparepart).WithMany(t => t.CategorySpareparts).HasForeignKey(pt => pt.SparepartId);


            builder.HasData(
                    new CategorySparepart { CategoryId = 1, SparepartId = 1 },
                    new CategorySparepart { CategoryId = 2, SparepartId = 2 },
                    new CategorySparepart { CategoryId = 3, SparepartId = 3 },
                    new CategorySparepart { CategoryId = 4, SparepartId = 4 },
                    new CategorySparepart { CategoryId = 5, SparepartId = 5 });

        }
    }
}
