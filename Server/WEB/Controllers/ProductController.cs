using AutoMapper;
using BAL.ProductServices;
using DAL.Entities;
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

        [HttpPost]
        public ActionResult Post([FromBody]PostProduct postProduct)
        {
            var product = _mapper.Map<Product>(postProduct);

            product = _productService.Create(product);

            var getProduct = _mapper.Map<GetProduct>(product);

            var jsonResult = Json(getProduct);

            jsonResult.StatusCode = 201;

            return jsonResult;
        }
    }
}
