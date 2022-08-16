using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserPostController : ControllerBase
    {
        private readonly IUserPost db;
        public UserPostController(IUserPost _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetUsers")]
        public IActionResult GetUsers()
        {
            IQueryable<UserPost> data = db.GetUserPosts;
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var data = db.GetUserPost(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());// return NotFound();

        }
        [HttpGet("{idUser}")]
        [ActionName("GetByUser")]
        public IActionResult GetByUser(int idUser)
        {
            var data = db.GetUserPostByUser(idUser);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());// return NotFound();

        }

        [HttpPost]
        public IActionResult AddUserPost([FromBody] UserPost userPost)
        {
            if (userPost == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
               var data= db.Save(userPost);
                if (data != null)
                    return Ok(data);
                else return Ok(new List<object>());//return NotFound();
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
