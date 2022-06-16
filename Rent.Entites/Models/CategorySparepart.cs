using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Entites.Models
{
    public class CategorySparepart
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SparepartId { get; set; }
        public Sparepart Sparepart { get; set; }
    }
}
