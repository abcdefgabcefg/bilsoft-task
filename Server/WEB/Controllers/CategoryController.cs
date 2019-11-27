using BAL.CategoryServices;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            var categories = _categoryService.GetAll();

            return Json(categories);
        }
    }
}
