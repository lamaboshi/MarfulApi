using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversationController : ControllerBase
    {
        private readonly IConversation db;
        public ConversationController(IConversation _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetConversation()
        {
            var data = db.GetConversations();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetConversation(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();

        }


        [HttpPost]
        public IActionResult AddConversation([FromBody] Conversation conversation)
        {
            if (conversation == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(conversation);
                return Ok();
            }

        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Conversation conversation)
        {
            if (conversation == null || conversation.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(conversation);
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
