using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Entites.Dto
{
    public class CreateSparepartDto
    {
        public string Name { get; set; }
        public int[] Categories { get; set; }
    }
}
