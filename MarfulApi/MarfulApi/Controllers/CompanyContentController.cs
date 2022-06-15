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
        [HttpGet("{id}")]
        public IActionResult GetCompanyContent(int id)
        {
            var data = db.GetCompanyContent(id);
            if(data != null)
            {
                return Ok(data);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpPost]
        public IActionResult AddCompanyContent([FromBody] CompanyContent companyContent)
        {
            if(companyContent == null)
            {
                return BadRequest();
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
                return BadRequest();
            }
            else
            {
                db.Update(companyContent);
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
