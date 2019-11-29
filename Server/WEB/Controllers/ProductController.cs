using AutoMapper;
using BAL.ProductServices;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WEB.Models;

namespace WEB.Controllers
{
    [Produces("application/json")]
    [ApiController]
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
        [ProducesResponseType(typeof(GetProductIncludeCategory[]), StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromQuery]int? skip, [FromQuery]int? take)
        {
            var products = await _productService.GetAsync(skip, take);

            var getProducts = _mapper.Map<List<GetProductIncludeCategory>>(products);

            return Json(getProducts);
        }

        [HttpPost]
        [ProducesResponseType(typeof(GetProduct), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post([FromBody]PostProduct postProduct)
        {
            var product = _mapper.Map<Product>(postProduct);

            var response = await _productService.CreateAsync(product);

            switch (response.Result)
            {
                case BAL.CreateProductResult.Success:
                    
                    var getProduct = _mapper.Map<GetProduct>(response.Product);

                    var jsonResult = Json(getProduct);

                    jsonResult.StatusCode = StatusCodes.Status201Created;

                    return jsonResult;
                
                case BAL.CreateProductResult.CategoryNotFound:

                    ModelState.AddModelError(nameof(PostProduct.Category), $"Category {postProduct.Category} not found");

                    return BadRequest(ModelState);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
