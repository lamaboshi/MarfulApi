using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCompanyController : ControllerBase
    {
        private readonly IUserCompany db;
        public UserCompanyController(IUserCompany _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetUserCompany()
        {
            IQueryable<UserCompany> data = db.GetUserCompanys;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetUserCompany(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddUserCompany([FromBody] UserCompany userCompany)
        {
            if (userCompany == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(userCompany);
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
