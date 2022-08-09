using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct db;
        public ProductController(IProduct _db)
        {
            db = _db;
        }
        [HttpGet("idBrand")]
        public IActionResult GetProduct(int idBrand)
        {
            List<Product> data = db.GetProducts(idBrand);
            return Ok(data);
        }
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var data= db.GetProduct(id);
        //    if (data != null)
        //    {
        //        return Ok(data);
        //    }
        //    return NotFound();

        //}

 
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(product);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put( [FromBody] Product product)
        {
            if (product == null || product.Id==0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(product);
                return Ok();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
           db.Delete(id);
            return Ok();
        }
    }
}
