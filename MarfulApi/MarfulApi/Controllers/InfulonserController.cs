using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InfulonserController : ControllerBase
    {
        private readonly IInfulonser db;
        public InfulonserController(IInfulonser _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetInfulonsers()
        {
            IQueryable<Infulonser> data = db.GetInfulonsers;
            return Ok(data);
        }
        [HttpGet("{idInfulonser}")]
        [ActionName("GetAllPosts")]
        public IActionResult GetAllPosts(int idInfulonser)
        {
            var data = db.getAllPostInfulonser(idInfulonser);
            if(data.Any()) return Ok(data);
            return BadRequest();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetInfulonser(id);
            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpPost]
        public IActionResult AddInfulonser([FromBody] Infulonser infulonser)
        {
            if(infulonser == null)
            {
                return BadRequest();
            }
            else
            {
                bool data = db.IsExisting(infulonser.Email);
                if (data == false)
                {
                    db.Save(infulonser);
                    return Ok();
                }
                else
                return NotFound();
        }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Infulonser infulonser)
        {
            if(infulonser == null || infulonser.Id==0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(infulonser);
                return Ok();
            }
        }
        [HttpPut]
        [ActionName("Password")]
        public IActionResult Password([FromQuery] int Id,[FromQuery] string password)
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
            if(email == null)
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
        [ActionName("GetFollowers")]
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
        [HttpGet]
        [ActionName("InfulonserBrandProduct")]
        public IActionResult InfulonserBrandProduct([FromQuery] string email)
        {
            if (email == null)
            {
                return BadRequest();
            }
            else
            {
                var data = db.GetInfulonserAll(email);
                if (data != null)
                    return Ok(data);
                else return NotFound();
            }
        }
    }
}
