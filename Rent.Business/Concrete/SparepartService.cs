using AutoMapper;
using Rent.Business.Abstract;
using Rent.Data.Abstract;
using Rent.Entites.Dto;
using Rent.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Business.Concrete
{
    public class SparepartService : ISparepartService
    {
        private readonly ISparepartRepository _sparepartRepository;
        private readonly IMapper _mapper;

        public SparepartService(ISparepartRepository sparepartRepository, IMapper mapper)
        {
            _sparepartRepository = sparepartRepository;
            _mapper = mapper;
        }

        public async Task<Sparepart> AddCategorySparepart(CreateSparepartDto sparepart)
        {
            var product = _mapper.Map<Sparepart>(sparepart);
            await _sparepartRepository.AddSparepart(product);
            foreach (var category in sparepart.Categories)
            {
                await _sparepartRepository.AddCategorySparepart(product.Id, category);
            }
            return product;
        }
    }
}
