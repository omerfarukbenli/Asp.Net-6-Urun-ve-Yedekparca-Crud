using Rent.Entites.Dto;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Abstract
{
    public interface ISparepartService
    {
        Task<Sparepart> AddCategorySparepart(CreateSparepartDto sparepart);
    }
}
