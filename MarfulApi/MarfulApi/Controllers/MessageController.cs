using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessage db;
        public MessageController(IMessage _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetMessages()
        {
            IQueryable<Message> data = db.GetMessages;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetMessage(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());//return NotFound();

        }


        [HttpPost]
        public IActionResult AddMessage([FromBody] Message message)
        {
            if (message == null)
            {
                return Ok(new List<object>());//return BadRequest();
            }
            else
            {
                db.SaveMessage(message);

                return Ok();
            }

        }
    }
}
