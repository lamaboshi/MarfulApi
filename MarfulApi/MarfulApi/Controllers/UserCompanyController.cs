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
        [HttpGet("{userId}")]
        public IActionResult GetAllUserCompanys(int userId)
        {
            var data = db.GetAllUserCompanys(userId);
            return Ok(data);
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
