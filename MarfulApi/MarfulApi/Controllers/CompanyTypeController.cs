using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyTypeController : ControllerBase
    {
        private readonly ICompanyType db;
        public CompanyTypeController(ICompanyType _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetCompanyType()
        {
            IQueryable<CompanyType> data = db.GetCompanyTypes;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetCompanyType(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddCompanyType([FromBody] CompanyType type)
        {
            if (type == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(type);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CompanyType type)
        {
            if (type == null || type.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(type);
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
