using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrand db;
        public BrandController(IBrand _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetBrands()
        {
            IQueryable<Brand> data = db.GetBrands;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetBrand(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());

        }


        [HttpPost]
        public IActionResult AddBrand([FromBody] Brand brand)
        {
            if (brand == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(brand);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Brand brand)
        {
            if (brand == null || brand.Id == 0)
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(brand);
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
