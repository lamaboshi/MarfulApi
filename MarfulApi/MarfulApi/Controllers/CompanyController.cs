using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompany db;
        public CompanyController(ICompany _db)
        {
            db = _db;
        }

        [HttpGet("{idContentCompany}")]
        [ActionName("GetAllBarndCompany")]
        public IActionResult GetAllBarndCompany(int idContentCompany)
        {
           var  data = db.GetCompanyBrand(idContentCompany);
            return Ok(data);
        }

        [HttpGet]
        [ActionName("GetAllCompany")]
        public IActionResult GetAllCompany()
        {
            IQueryable<Company> data = db.GetCompanys;
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("GetCompany")]
        public IActionResult GetCompany(int id)
        {
            var data = db.GetCompany(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }
        [HttpGet("{idCompany}")]
        [ActionName("GetAllPosts")]
        public IActionResult GetAllPosts(int idCompany)
        {
            var data = db.GetAllCompanyPost(idCompany);
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
        [HttpPut]
        [ActionName("Password")]
        public IActionResult Password([FromQuery] int Id,[FromQuery]string password)
        {
            if (password == null || Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.ChangePassword(Id,password);
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
        [ActionName("GetFollowersCount")]
        public IActionResult GetFollowersCount([FromQuery] string email)
        {
            if (email == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetFollowersCount(email);
                if (data != -1)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName(" GetFollowers")]
        public IActionResult GetFollowers([FromQuery] string email)
        {
            if (email == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetFollowers(email);
                if (data != null)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
    }
}
