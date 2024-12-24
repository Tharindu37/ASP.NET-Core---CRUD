using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //[HttpGet]
        //public string[] products()
        //{
        //    return new string[] { "product1", "product2" };
        //}

        [HttpGet]
        public IActionResult products()
        {
            var products = new string[] { "product1", "product2" };
            return Ok(products);
        }

        [HttpPost]
        public IActionResult newProduct()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult deleteProduct()
        {
            var error = true;
            if (error)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult updateProduct()
        {
            return Ok();
        }
    }
}
