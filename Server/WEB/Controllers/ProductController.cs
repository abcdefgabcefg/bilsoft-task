using AutoMapper;
using BAL.ProductServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WEB.Models;

namespace WEB.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get([FromQuery]int? skip, [FromQuery]int? take)
        {
            var products = _productService.Get(skip, take);

            var getProducts = _mapper.Map<List<GetProduct>>(products);

            return Json(getProducts);
        }
    }
}
