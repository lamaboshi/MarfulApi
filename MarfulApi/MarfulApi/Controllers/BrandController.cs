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
        [HttpPost]
        public IActionResult AddBrand([FromBody] Brand brand)
        {
            if(brand != null)
            {
                return BadRequest();
            }
            db.Save(brand);
            return Ok();
        }
    }
}
