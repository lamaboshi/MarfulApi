using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPostController : ControllerBase
    {
        private readonly IUserPost db;
        public UserPostController(IUserPost _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetUser()
        {
            IQueryable<UserPost> data = db.GetUserPosts;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetUserPost(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddUserPost([FromBody] UserPost userPost)
        {
            if (userPost == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(userPost);
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
