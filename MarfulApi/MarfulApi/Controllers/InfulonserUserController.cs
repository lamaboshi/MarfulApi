using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InfulonserUserController : ControllerBase
    {
        private readonly IInfulonserUser db;
        public InfulonserUserController(IInfulonserUser _db)
        {
            db = _db;
        }
        [HttpGet("{userId}")]
        [ActionName("GetAllInfilonserUsers")]
        public IActionResult GetAllInfilonserUsers(int userId)
        {
            var data = db.GetAllInfulonserUsers(userId);
            return Ok(data);
        }
        [HttpGet("{userId}")]
        [ActionName("GetInfilonserUser")]
        public IActionResult GetInfilonserUser(int userId)
        {
            var data = db.GetInfulonserUser(userId);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult AddInfulonserUser([FromBody] InfulonserUser infulonserUser)
        {
            if(infulonserUser == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(infulonserUser);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] InfulonserUser infulonserUser)
        {
            if(infulonserUser == null || infulonserUser.Id== 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(infulonserUser);
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
