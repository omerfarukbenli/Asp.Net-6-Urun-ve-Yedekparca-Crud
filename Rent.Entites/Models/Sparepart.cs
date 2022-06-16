using Rent.Entites.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Entites.Models
{
    public class Sparepart:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public ICollection<CategorySparepart> CategorySpareparts { get; set; }
    }
}
