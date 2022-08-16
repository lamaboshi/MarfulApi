using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
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
            // return NotFound();
            return Ok(new List<object>());
        }
        [HttpPost]
        public IActionResult AddCompanyType([FromBody] CompanyType type)
        {
            if (type == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
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
                // return BadRequest();
                return Ok(new List<object>());
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
        [HttpGet]
        [ActionName("Existing")]
        public IActionResult Existing([FromQuery] string Type,[FromQuery] string password)
        {
            if(Type == null || password == null)
            {
                //  return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                var data = db.IsExisting(Type, password);
                if (data != null)
                {
                    return Ok(data);
                }
                else return Ok(new List<object>()); //return NotFound();
            }
        }
        [HttpGet]
        [ActionName("GetTypes")]
        public IActionResult GetTypes([FromQuery] int IdCmp)
        {
            if(IdCmp ==0)
            {
                //return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                var data = db.getTypes(IdCmp);
                if (data != null)
                {
                    return Ok(data);
                }
                else return Ok(new List<object>());//return NotFound();
            }
        }
    }
}
