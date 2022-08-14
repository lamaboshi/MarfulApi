using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfulonserFollowInfulonserController : ControllerBase
    {
        private readonly IInfulonserFollowInfulonser db;
        public InfulonserFollowInfulonserController(IInfulonserFollowInfulonser _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult GetInfulonserFollow()
        {
            IQueryable<InfulonserFollowInfulonser> data = db.GetInfulonserFollowInfulonsers;
            return Ok(data);
        }
        [HttpGet("{idFollow}")]
        public IActionResult Get(int idFollow)
        {
            var data = db.GetInfulonserFollowInfulonser(idFollow);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult AddInfulonserFollow([FromBody] InfulonserFollowInfulonser infulonserFollowInfulonser)
        {
            if (infulonserFollowInfulonser == null)
            {
                return BadRequest();
            }
            else
            {
                db.Save(infulonserFollowInfulonser);
                return Ok();
            }
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] InfulonserFollowInfulonser infulonserFollowInfulonser)
        {
            if (infulonserFollowInfulonser == null || infulonserFollowInfulonser.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.Update(infulonserFollowInfulonser);
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
   
