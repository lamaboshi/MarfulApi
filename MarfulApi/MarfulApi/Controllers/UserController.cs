using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUser db;
        public UserController(IUser _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            IQueryable<User> data = db.GetUsers;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetUser(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(user);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] User user)
        {
            if (user == null || user.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(user);
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
