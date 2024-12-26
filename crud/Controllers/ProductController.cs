using AutoMapper;
using crud.Models;
using crud.Services.Models;
using crud.Services.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    //[Route("api/products")]
    [Route("api/users/{userId}/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //private ProductService _productService;

        //public ProductController()
        //{
        //    _productService=new ProductService();
        //}

        private readonly IProductRepository _productService;
        private readonly IMapper _mapper;
        public ProductController(IProductRepository repository, IMapper mapper)
        {
            _productService = repository;
            _mapper = mapper;
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

        //[HttpGet]
        //public IActionResult products()
        //{
        //    var products = _productService.allProducts();
        //    return Ok(products);
        //}

        // Day 7
        [HttpGet]
        public IActionResult products(int userId)
        {
            var products = _productService.GetProducts(userId);
            var productsDto = _mapper.Map<ICollection<ProductDto>>(products);
            return Ok(productsDto);
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

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult product(int userId, int id)
        {
            //var product = _productService.getProduct(id);
            var product = _productService.GetProduct(userId, id);
            if (product == null)
                return NotFound();
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpPost]
        public ActionResult<ProductDto> AddProduct(int userId, CreateProductDto product)
        {
            var productEntity = _mapper.Map<Product>(product);
            var newProduct = _productService.AddProduct(userId, productEntity);
            var returnProduct = _mapper.Map<ProductDto>(newProduct);
            return CreatedAtRoute("GetProduct", new { userId = userId, id = returnProduct.Id }, returnProduct);
        }

        [HttpPut("{productId}")]
        public ActionResult UpdateProduct(int userId, int productId, UpdateProductDto product)
        {
            var updateProduct = _productService.GetProduct(userId, productId);
            if (updateProduct is null)
            {
                return NotFound();
            }
            _mapper.Map(product, updateProduct);
            _productService.UpdateProduct(updateProduct);
            return NoContent();
        }

        [HttpDelete("{productId}")]
        public ActionResult DeleteProduct(int userId, int productId)
        {
            var product = _productService.GetProduct(userId, productId);
            if (product is null)
            {
                return NotFound();
            }
            _productService.DeleteProduct(product);
            return NoContent();
        }
    }
}
