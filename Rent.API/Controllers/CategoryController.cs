using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rent.Business.Abstract;
using Rent.Entites.Dto;
using Rent.Entites.Models;

namespace Rent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {

        private readonly IMapper _mapper;
        private readonly IService<Category> _service;

        public CategoryController(IMapper mapper, IService<Category> service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var spareparts = await _service.GetAllAsync();
            var sparepartsDtos = _mapper.Map<List<GetCategoryListProduct>>(spareparts.ToList());
            return CreateActionResult(CustomResponseDto<List<GetCategoryListProduct>>.Success(200, sparepartsDtos));
        }
    }
}
