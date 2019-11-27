using BAL.ProductServices;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get([FromQuery]int? skip, [FromQuery]int? take)
        {
            var products = _productService.Get(skip, take);

            return Json(products);
        }
    }
}
