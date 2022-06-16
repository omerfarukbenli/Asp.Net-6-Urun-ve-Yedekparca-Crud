using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Abstract
{
    public interface ISparepartRepository
    {
        Task AddSparepart<T>(T entity) where T : class;
        Task AddCategorySparepart(int id, int cat);
    }
}
