using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Data;
using MarfulApi.Infrastructure;
namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMain db;
        public MainController(IMain _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("Posts")]
        public IActionResult Posts([FromQuery]string email)
        {
            if (email == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetPost(email);
                if (data != null)
                    return Ok(data);
                else
                    return NotFound();
            }
        }
        [HttpGet]
        [ActionName("PostsContent")]
        public IActionResult PostsContent(int id, string email)
        {
            if (email == null || id == 0)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetPostByConent(id, email);
                if (data != null)
                    return Ok(data);
                else
                    return NotFound();
            }
        }
    }
}
