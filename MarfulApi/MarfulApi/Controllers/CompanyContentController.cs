using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyContentController : ControllerBase
    {
        private readonly ICompanyContent db;
        public CompanyContentController(ICompanyContent _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult Get()
        {
            IQueryable<CompanyContent> data = db.GetCompanyContents;
            return Ok(data);
        }
        [HttpGet("{idCompa}")]
        public IActionResult GetAllInfulonserContents(int idCompa)
        {
            var data = db.GetAllCompanyContents(idCompa);
            if (data == null) { return NotFound(); }
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddCompanyContent([FromBody] CompanyContent companyContent)
        {
            if(companyContent == null)
            {
                //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(companyContent);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] CompanyContent companyContent)
        {
            if(companyContent ==null || companyContent.Id==0)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(companyContent);
                return Ok();
            }
        }
        [HttpDelete("{id}/{IdComp}")]
        public IActionResult Delete(int id, int IdComp)
        {
            db.Delete(id, IdComp);
            return Ok();
        }

    }
}
