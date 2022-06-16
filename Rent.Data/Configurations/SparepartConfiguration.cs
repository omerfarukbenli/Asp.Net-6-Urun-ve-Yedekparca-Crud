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
    public class SparepartConfiguration : IEntityTypeConfiguration<Sparepart>
    {
        public void Configure(EntityTypeBuilder<Sparepart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();


            builder.HasData(
                    new Sparepart { Id = 1, Name = "arabalar" },
                    new Sparepart { Id = 2, Name = "arabalar" },
                    new Sparepart { Id = 3, Name = "arabalar" },
                    new Sparepart { Id = 4, Name = "arabalar" },
                    new Sparepart { Id = 5, Name = "arabalar" });

        }
    }
}
