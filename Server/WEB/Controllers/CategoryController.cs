using AutoMapper;
using BAL.CategoryServices;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB.Models;

namespace WEB.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(typeof(GetCategory[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllAsync();

            var getCategories = _mapper.Map<List<GetCategory>>(categories);

            return Json(getCategories);
        }
    }
}
