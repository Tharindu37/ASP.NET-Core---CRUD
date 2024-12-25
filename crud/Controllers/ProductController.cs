using crud.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private ProductService _productService;

        //public ProductController()
        //{
        //    _productService=new ProductService();
        //}

        private readonly IProductRepository _productService;
        public ProductController(IProductRepository repository)
        {
            _productService = repository;
        }

        // Day 1

        //[HttpGet]
        //public string[] products()
        //{
        //    return new string[] { "product1", "product2" };
        //}

        // Day 2

        //[HttpGet]
        //public IActionResult products()
        //{
        //    var products = new string[] { "product1", "product2" };
        //    return Ok(products);
        //}

        //[HttpPost]
        //public IActionResult newProduct()
        //{
        //    return Ok();
        //}

        //[HttpDelete]
        //public IActionResult deleteProduct()
        //{
        //    var error = true;
        //    if (error)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok();
        //}

        //[HttpPut]
        //public IActionResult updateProduct()
        //{
        //    return Ok();
        //}

        // Day 3

        [HttpGet]
        public IActionResult products()
        {
            var products = _productService.allProducts();
            return Ok(products);
        }



        //[HttpPost("{id}")]
        //public IActionResult product(int id)
        //{
        //    var product = allProducts().Where(p => p.Id == id);
        //    return Ok(product);
        //}

        //[HttpGet("{id?}")]
        //public IActionResult product(int? id)
        //{
        //    if (id is null)
        //        return Ok(_productService.allProducts());
        //    var product = _productService.allProducts().Where(p => p.Id == id);

        //    return Ok(product);
        //}

        [HttpGet("{id}")]
        public IActionResult product(int id)
        {
            var product = _productService.getProduct(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
