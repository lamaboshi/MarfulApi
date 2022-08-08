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
        [HttpGet("{idInful}")]
        public IActionResult GetAllInfulonserContents(int idInful)
        {
           var data = db.GetAllInfulonserContents(idInful);
            if (data ==null) { return NotFound(); }
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
        [HttpDelete("{id}/{IdInu}")]
        public IActionResult Delete(int id, int IdInu)
        {
            db.Delete(id,IdInu);
            return Ok();
        }
    }
}
