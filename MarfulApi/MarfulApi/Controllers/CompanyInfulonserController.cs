using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyInfulonserController : ControllerBase
    {
        private readonly ICompanyInfulonser db;
        public CompanyInfulonserController(ICompanyInfulonser _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetInfulonserCompany()
        {
            IQueryable<CompanyInfulonser> data = db.GetInfulonserCompanies;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetInfulonserCompany(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddBasket([FromBody] CompanyInfulonser companyInfulonser)
        {
            if (companyInfulonser == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(companyInfulonser);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CompanyInfulonser companyInfulonser)
        {
            if (companyInfulonser == null || companyInfulonser.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(companyInfulonser);
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
