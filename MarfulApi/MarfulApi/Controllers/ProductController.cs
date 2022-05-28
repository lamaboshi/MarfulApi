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
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetProduct()
        {
            IQueryable<Product> data = db.GetProducts;
            return Ok(data);
        }
        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

 
        [HttpPost]
        public IActionResult AddBrand([FromBody] Product product)
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
        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
