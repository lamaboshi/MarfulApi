using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MarfulApi.Infrastructure;
using MarfulApi.Model;

namespace MarfulApi.Controllers
{
    [Route("api/[controller]")]
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
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = db.GetInfulonser(id);
            if(data== null)
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
        public IActionResult Password([FromBody] Infulonser infulonser)
        {
            if (infulonser == null || infulonser.Id == 0)
            {
                return BadRequest();
            }
            else
            {
                db.ChangePassword(infulonser);
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
