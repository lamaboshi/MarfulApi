using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany db;
        public CompanyController(ICompany _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetCompany()
        {
            IQueryable<Company> data = db.GetCompanys;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetCompany(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddCompany([FromBody] Company company)
        {
            if (company == null)
            {
                return BadRequest();
            }
            else
            {
                bool data = db.IsExisting(company.Email);
                if (data == false)
                {
                    db.Save(company);
                    return Ok();
                }
                else return NotFound();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Company company)
        {
            if (company == null || company.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(company);
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
