using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostInfulonserController : ControllerBase
    {
        private readonly IPostInfulonser db;
        public PostInfulonserController(IPostInfulonser _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetPostInteraction()
        {
            IQueryable<PostInfulonser> data = db.GetPostInfulonsers;
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetPostInfulonser(id);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddPostInfulonser([FromBody] PostInfulonser postInfulonser)
        {
            if (postInfulonser == null)
            {
                return BadRequest();
            }
            else
            {
              var data= db.Save(postInfulonser);
                if (data != null)
                    return Ok();
                else return NotFound();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] PostInfulonser postInfulonser)
        {
            if (postInfulonser == null || postInfulonser.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(postInfulonser);
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
