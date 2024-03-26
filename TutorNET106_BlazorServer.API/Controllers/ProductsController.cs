using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using TutorNET106_BlazorServer.API.Services;

namespace TutorNET106_BlazorServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("id:int")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.CreateProduct(product);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpPut]
        public IActionResult EditProduct(Product product)
        {
            _productService.EditProduct(product);
            return StatusCode(StatusCodes.Status200OK);
        }

        [HttpDelete("id:int")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
