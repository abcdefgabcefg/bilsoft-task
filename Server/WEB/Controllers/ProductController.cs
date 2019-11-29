using AutoMapper;
using BAL.ProductServices;
using DAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        [ProducesResponseType(typeof(GetProduct[]), StatusCodes.Status200OK)]
        public ActionResult Get([FromQuery]int? skip, [FromQuery]int? take)
        {
            var products = _productService.Get(skip, take);

            var getProducts = _mapper.Map<List<GetProduct>>(products);

            return Json(getProducts);
        }

        [HttpPost]
        [ProducesResponseType(typeof(GetProduct), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(IDictionary<string, string[]>), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody]PostProduct postProduct)
        {
            var product = _mapper.Map<Product>(postProduct);

            var response = await _productService.CreateAsync(product);

            switch (response.Result)
            {
                case BAL.CreateProductResult.Success:
                    
                    var getProduct = _mapper.Map<GetProduct>(response.Product);

                    var jsonResult = Json(getProduct);

                    jsonResult.StatusCode = 201;

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
