using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;


namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfulonserContentController : ControllerBase
    {
        private readonly IInfulonserContent db;
        public InfulonserContentController(IInfulonserContent _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetInfulonserContents()
        {
            IQueryable<InfulonserContent> data = db.GetInfulonserContents;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetInfulonserContent(id);
            if (data == null)
            {
                return NotFound();
            }
            else
                return Ok(data);
        }
        [HttpPost]
        public IActionResult AddInfulonserContent([FromBody] InfulonserContent infulonserContent)
        {
            if(infulonserContent== null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(infulonserContent);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] InfulonserContent infulonserContent)
        {
            if(infulonserContent == null || infulonserContent.Id==0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(infulonserContent);
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
