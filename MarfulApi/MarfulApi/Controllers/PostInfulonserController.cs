using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostInfulonserController : ControllerBase
    {
        private readonly IPostInfulonser db;
        public PostInfulonserController(IPostInfulonser _db)
        {
            db = _db;
        }
        [HttpGet]
        [ActionName("GetPostInteraction")]
        public IActionResult GetPostInteraction()
        {
            IQueryable<PostInfulonser> data = db.GetPostInfulonsers;
            return Ok(data);
        }
        [HttpGet("{id}")]
        [ActionName("Get")]
        public IActionResult Get(int id)
        {
            var data = db.GetPostInfulonser(id);
            if (data != null)
            {
                return Ok(data);
            }
            return Ok(new List<object>());// return NotFound();
        }
        [HttpGet("{idInfu}")]
        [ActionName("GetByInfu")]
        public IActionResult GetByInfu(int idInfu)
        {
            var data = db.GetUserPostByInfu(idInfu);
            if (data != null)
            {
                return Ok(data);
            }
            // return NotFound();
            return Ok(new List<object>());
        }




        [HttpPost]
        public IActionResult AddPostInfulonser([FromBody] PostInfulonser postInfulonser)
        {
            if (postInfulonser == null)
            {
                return Ok(new List<object>());// return BadRequest();
            }
            else
            {
              var data= db.Save(postInfulonser);
                if (data != null)
                    return Ok(data);
                else return Ok(new List<object>());//return NotFound();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] PostInfulonser postInfulonser)
        {
            if (postInfulonser == null || postInfulonser.Id == 0)
            {
                return Ok(new List<object>());//return BadRequest();
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
