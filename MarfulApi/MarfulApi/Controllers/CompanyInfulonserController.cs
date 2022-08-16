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
        [HttpGet("{idcompany}/{idInfo}")]
        public IActionResult Get(int idcompany,int idInfo)
        {
            var data = db.GetInfulonserCompany(idcompany, idInfo);
            if (data != null)
            {
                return Ok(data);
            }
            // return NotFound();
            return Ok(new List<object>());
        }
        [HttpPost]
        public IActionResult AddBasket([FromBody] CompanyInfulonser companyInfulonser)
        {
            if (companyInfulonser == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
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
                //return BadRequest();
                return Ok(new List<object>());
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
