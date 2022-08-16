using MarfulApi.Infrastructure;
using MarfulApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : ControllerBase
    {
        private readonly IContent db;
        public ContentController(IContent _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetContents()
        {
            IQueryable<Content> data = db.GetContents;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetContent(id);
            if (data != null)
            {
                return Ok(data);
            }
            else
            {
                // return NotFound();
                return Ok(new List<object>());
            }
        }
        [HttpPost]
        public IActionResult AddContent([FromBody] Content content)
        {
            if (content == null)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Save(content);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Content content)
        {
            if(content==null || content.Id==0)
            {
                // return BadRequest();
                return Ok(new List<object>());
            }
            else
            {
                db.Update(content);
                return Ok();
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            db.Delete(id);
            return Ok();
        }
    }
}
