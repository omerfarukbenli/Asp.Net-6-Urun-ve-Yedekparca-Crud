using Rent.Data.Abstract;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Data.Concrete
{
    public class SparepartRepository : ISparepartRepository
    {
        private readonly DataContext _context;
        private readonly IUnitOfWork _unitOfWork;

        public SparepartRepository(DataContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _unitOfWork = unitOfWork;
        }

        public async Task AddCategorySparepart(int id, int cat)
        {
            var category = _context.Categories.Find(cat);

            var sparepart = _context.Spareparts.FirstOrDefault(a => a.Id == id);

            CategorySparepart newprocat = new CategorySparepart
            {
                Category = category,
                Sparepart = sparepart
            };
            await _context.Set<CategorySparepart>().AddAsync(newprocat);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddSparepart<T>(T entity) where T : class
        {
            await _context.Set<T>().AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }
    }
}
