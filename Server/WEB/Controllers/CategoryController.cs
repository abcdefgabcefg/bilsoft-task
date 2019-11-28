using BAL.CategoryServices;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult Get()
        {
            var categories = _categoryService.GetAll();

            return Json(categories);
        }
    }
}
