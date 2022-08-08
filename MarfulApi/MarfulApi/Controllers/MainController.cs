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
        public IActionResult Posts([FromQuery]string email,[FromQuery]string Type)
        {
            if (email == null || Type== null)
            {
                return BadRequest();
            }
            else
            {
                object data = new object();
                if (Type == "user")
                    data = db.GetUserPost(email);
                else if (Type == "infulonser")
                    data = db.GetInfulonserPost(email);
                else if (Type == "comapny")
                    data = db.GetCompanyPost(email);
                if (data != null)
                    return Ok(data);
                else
                    return NotFound();
            }
        }
        [HttpGet]
        [ActionName("PostsContent")]
        public IActionResult PostsContent(int id, string email,string Type)
        {
            if (email == null || id == 0)
            {
                return BadRequest();
            }
            else
            {
                object data = new object();
                if (Type == "user")
                    data = db.GetUserPostByConent(id, email);
                else if (Type == "infulonser")
                    data = db.GetInfulonserPostByConent(id, email);
                else if (Type == "comapny")
                    data = db.GetCompanyPostByConent(id, email);
                if (data != null)
                    return Ok(data);
                else
                    return NotFound();
            }
        }
        [HttpGet]
        [ActionName("GetLikes")]
        public IActionResult GetLikes([FromQuery] int id,[FromQuery] string type)
        {
            if(id==0 || type== null)
            {
               return BadRequest();
            }
            else
            {
                var data = db.GetLikesCount(id, type);
                if (data != -1)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
        [HttpGet]
        [ActionName("GeDistLikes")]
        public IActionResult GetDisLikes([FromQuery] int id, [FromQuery] string type)
        {
            if (id == 0 || type == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetDisLikesCount(id, type);
                if (data != -1)
                {
                    return Ok(data);
                }
                else return NotFound();
            }
        }
    }
}
