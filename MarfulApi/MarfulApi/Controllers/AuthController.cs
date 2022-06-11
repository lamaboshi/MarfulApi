using MarfulApi.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuth db;
        public AuthController(IAuth _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetAuth([FromQuery] string email, [FromQuery] string password)
        {
           var data = db.GetAuth(email,password);
            if (data != null) return Ok(data);
            else return NotFound();

        }
    }
}
