using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPost db;
        public PostController(IPost _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetPost()
        {
            IQueryable<Post> data = db.GetPosts;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetPost(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddPost([FromBody] Post post)
        {
            if (post == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(post);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Post post)
        {
            if (post == null || post.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(post);
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
